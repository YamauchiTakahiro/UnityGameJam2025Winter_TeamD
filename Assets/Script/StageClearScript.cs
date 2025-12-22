using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClearScript : MonoBehaviour
{
    [SerializeField] GameObject GameManager;
    GameManagerScript gameManagerScript;

   public int stageNumber;

    private void Awake()
    {
        if (GameManager != null)
        {
            gameManagerScript = GameManager.GetComponent<GameManagerScript>();
            if (gameManagerScript == null)
                Debug.LogWarning("StageClearScript: GameManager に GameManagerScript が見つかりません。");
        }
        else
        {
            Debug.LogWarning("StageClearScript: GameManager が Inspector にセットされていません。");
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StageClear()
    {
        // 現在のステージ番号を取得
        if (gameManagerScript.GetRank() < stageNumber)
        {
            gameManagerScript.SetRank(stageNumber);
        }
    }
}
