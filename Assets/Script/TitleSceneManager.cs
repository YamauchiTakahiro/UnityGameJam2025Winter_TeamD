using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// タイトルシーンマネージャー
/// </summary>
public class TitleSceneManager : MonoBehaviour
{
    [Header("ゲームスタートボタン"), SerializeField]
    Button _gameStartButton;

    /// <summary>
    /// Awake
    /// </summary>
    private void Awake()
    {
        // ゲームスタートボタンのリスナー登録
        _gameStartButton.onClick.AddListener(OnClickGameStartButton);
    }

    /// <summary>
    /// ゲームスタートボタン押下時
    /// </summary>
    private void OnClickGameStartButton()
    {
        // インゲームに遷移
        SceneManager.LoadScene("InGame");
    }
}
