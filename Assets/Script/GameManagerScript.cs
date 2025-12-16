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

    [SerializeField] GameObject playerPrefab;

    PlayerScript playerScript;

    [SerializeField] GameObject summonButton;

    SummonButtonScript summonButtonScript;
    // Start is called before the first frame update
    void Start()
    {
        
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
        summonButtonScript = summonButton.GetComponent<SummonButtonScript>();
        summonButtonScript.SummonButton();
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
