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

    [Header("設定ボタン"), SerializeField]
    Button _OptionButton;

    /// <summary>
    /// Awake
    /// </summary>
    private void Awake()
    {
        // ゲームスタートボタンのリスナー登録
        _gameStartButton.onClick.AddListener(OnClickGameStartButton);
        // 設定ボタンのリスナー登録
        _OptionButton.onClick.AddListener(OnClickOptionButton);
    }

    /// <summary>
    /// ゲームスタートボタン押下時
    /// </summary>
    private void OnClickGameStartButton()
    {
        // インゲームに遷移
        SceneManager.LoadScene("WorldMap");
    }

    /// <summary>
    /// 設定ボタン押下時
    /// </summary>
    private void OnClickOptionButton()
    {
        // 設定シーンに遷移
        SceneManager.LoadScene("Option");
    }
}
