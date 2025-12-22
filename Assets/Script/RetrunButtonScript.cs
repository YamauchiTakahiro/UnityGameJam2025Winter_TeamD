using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetrunButtonScript : MonoBehaviour
{
    [Header("戻るボタン"), SerializeField]
    Button _retrunButton;

    private void Awake()
    {
        // ボタンが押されたときに実行する関数を登録
        _retrunButton.onClick.AddListener(OnClickReturnButton);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickReturnButton()
    {
        // タイトルシーンに遷移
        SceneManager.LoadScene("Title");
    }
}
