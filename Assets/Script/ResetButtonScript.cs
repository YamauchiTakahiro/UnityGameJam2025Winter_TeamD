using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonScript : MonoBehaviour
{
    [Header("リセットボタン"), SerializeField]
    Button _resetButton;

    [SerializeField]GameObject SeSliderObject;
    SeVolumeScript SeVolumeScript;

    [SerializeField] GameObject BGMSliderObject;
    BgmVolumeScript BGMVolumeScript;

    private void Awake()
    {
        SeVolumeScript = SeSliderObject.GetComponent<SeVolumeScript>();
        BGMVolumeScript = BGMSliderObject.GetComponent<BgmVolumeScript>();
        // リセットボタンのリスナー登録
        _resetButton.onClick.AddListener(OnClickGameResetButton);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnClickGameResetButton()
    {
        // PlayerPrefsの全データを削除
        PlayerPrefs.DeleteAll();
        SeVolumeScript.OnSeSliderValueChanged(0.5f);
        BGMVolumeScript.OnBGMSliderValueChanged(0.5f);
    }
}
