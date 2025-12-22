using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DanRankManagerScript : MonoBehaviour
{
    [Header("初級ボタン"), SerializeField]
    Button _beginnerButton;
    [Header("中級ボタン"), SerializeField]
    Button _intermediateButton;
    [Header("上級ボタン"), SerializeField]
    Button _advancedButton;

    private void Awake()
    {
        _beginnerButton.onClick.AddListener(OnClickBeginnerButton);
        _intermediateButton.onClick.AddListener(OnClickIntermediateButton);
        _advancedButton.onClick.AddListener(OnClickAdvancedButton);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnClickBeginnerButton()
    {
        SceneManager.LoadScene("Stage1");
    }

    private void OnClickIntermediateButton()
    {
        SceneManager.LoadScene("Stage2");
    }

    private void OnClickAdvancedButton()
    {
        SceneManager.LoadScene("Stage3");
    }
}
