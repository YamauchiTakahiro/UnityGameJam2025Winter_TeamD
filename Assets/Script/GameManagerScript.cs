using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


enum GameStatus
{
    None,
    Init,
    Title,
    WorldMap,
    Stage1,
    Stage2,
    Stage3,
    Option,
    GameOver,
    GameClear,
    Result
}


public class GameManagerScript : MonoBehaviour
{
    [SerializeField] GameObject PlayerCasle;
    [SerializeField] GameObject EnemyCasle;
    [SerializeField] GameObject MainCamera;

    [SerializeField] ReceptionistScript _receptionist; // Inspector に ReceptionistScript をアサイン
    [SerializeField] GameObject StageClear;
    StageClearScript stageClearScript;


    HPScript PlayerCasleHP;
    HPScript EnemyCasleHP;

    // 一度だけ呼ぶためのフラグ
    private bool _enemyDeathHandled = false;
    private bool _playerDeathHandled = false;
    public static GameManagerScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        stageClearScript = StageClear.GetComponent<StageClearScript>();

        if (PlayerCasle != null)
        {
            PlayerCasleHP = PlayerCasle.GetComponent<HPScript>();
            if (PlayerCasleHP == null)
                Debug.LogWarning("GameManagerScript: PlayerCasle に HPScript が見つかりません。");
        }
        else
        {
            Debug.LogWarning("GameManagerScript: PlayerCasle が Inspector にセットされていません。");
        }

        if (EnemyCasle != null)
        {
            EnemyCasleHP = EnemyCasle.GetComponent<HPScript>();
            if (EnemyCasleHP == null)
                Debug.LogWarning("GameManagerScript: EnemyCasle に HPScript が見つかりません。");
        }
        else
        {
            Debug.LogWarning("GameManagerScript: EnemyCasle が Inspector にセットされていません。");
        }

        if (_receptionist == null)
        {
            Debug.LogWarning("GameManagerScript: _receptionist が Inspector にセットされていません。");
        }
    }


    //ゲームが始まっているかどうか
    public bool isGame = false;
    GameStatus gameStatus = GameStatus.Title;


    void Start()
    {
        isGame = true;
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 敵城のHPが0以下になったら一度だけ受付嬢のセリフを表示
        if (!_enemyDeathHandled && EnemyCasleHP != null && EnemyCasleHP.hp <= 0)
        {
            _enemyDeathHandled = true;
            if (_receptionist != null)
            {
                _receptionist.ShowRandomLine();
                stageClearScript.StageClear();
                SceneManager.LoadScene("WorldMap");
            }
        }

        // プレイヤー城が破壊されたとき敗北時の受付嬢のセリフを表示
        if (!_playerDeathHandled && PlayerCasleHP != null && PlayerCasleHP.hp <= 0)
        {
            _playerDeathHandled = true;
            if (_receptionist != null) {
                _receptionist.ShowDefeatLine();
                SceneManager.LoadScene("WorldMap");
            }
        }
    }

    public int GetRank()
    {
        return PlayerPrefs.GetInt("Rank", 0);
    }

    public void SetRank(int rank)
    {
         PlayerPrefs.SetInt("Rank", rank);
    }
}
