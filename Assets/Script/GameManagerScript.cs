using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum GameStatus
{
    None,
    Init,
    Title,
    WordSelect,
    InGame,
    GameOver,
    GameClear,
    Result
}

public class GameManagerScript : MonoBehaviour
{
    GameStatus gameStatus = GameStatus.Title;

    [SerializeField] GameObject summonButton1;

    SummonButtonScript summonButtonScript1;

    [SerializeField] GameObject summonButton2;

    SummonButtonScript summonButtonScript2;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        //表示数を減らす
    }

    // Update is called once per frame
    void Update()
    {
        PlayerGameStatus();
    }

    void PlayerGameStatus()
    {
        switch (gameStatus)
        {
            case GameStatus.Title:
                PlayTitle();
                break;
            case GameStatus.WordSelect:
                PlayWordSelect();
                break;
            case GameStatus.InGame:
                PlayInGame();
                break;
            case GameStatus.GameOver:
                PlayGameOver();
                break;
            case GameStatus.GameClear:
                PlayGameClear();
                break;
            case GameStatus.Result:
                PlayerResult();
                break;
        }

    }

    void SetGameStatus(GameStatus nextGameStatus)
    {
        gameStatus = nextGameStatus;
    }

    void PlayTitle()
    {
        SetGameStatus(GameStatus.InGame);
    }

    void PlayWordSelect()
    {
    }

    void PlayInGame()
    {
        summonButtonScript1 = summonButton1.GetComponent<SummonButtonScript>();
        summonButtonScript1.SummonButton();
        summonButtonScript2 = summonButton2.GetComponent<SummonButtonScript>();
        summonButtonScript2.SummonButton();
    }

    void PlayGameOver()
    {
    }

    void PlayGameClear()
    {
    }

    void PlayerResult()
    {

    }
}
