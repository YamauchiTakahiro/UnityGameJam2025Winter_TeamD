using Unity.VisualScripting;
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
    Button _optionButton;

    /// <summary>
    /// Awake
    /// </summary>
    private void Awake()
    {
        // ゲームスタートボタンのリスナー登録
        _gameStartButton.onClick.AddListener(OnClickGameStartButton);
        // 設定ボタンのリスナー登録
        _optionButton.onClick.AddListener(OnClickGameOptionButton);
 
    }

    /// <summary>
    /// ゲームスタートボタン押下時
    /// </summary>
    private void OnClickGameStartButton()
    {
        // インゲームに遷移
        SceneManager.LoadScene("InGame");        
    }

    /// <summary>
    /// 設定ボタン押下時
    /// </summary>
    private void OnClickGameOptionButton()
    {
        // オプションシーンに遷移
        SceneManager.LoadScene("Option");
    }
}
