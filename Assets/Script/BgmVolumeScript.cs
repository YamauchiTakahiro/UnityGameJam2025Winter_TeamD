using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmVolumeScript : MonoBehaviour
{
    [SerializeField] GameObject OptionManager;
    OptionManagerScript optionManagerScript;

    [SerializeField]GameObject BgmVolumeText;
    BgmVolumTextScript bgmVolumTextScript;

    [Header("BGM音量設定スライダー")]
    [SerializeField] private Slider BGMSlider;


        public void Awake()
    {
        optionManagerScript = OptionManager.GetComponent<OptionManagerScript>();
        BGMSlider.value = optionManagerScript.GetBGMVolume();
        bgmVolumTextScript = BgmVolumeText.GetComponent<BgmVolumTextScript>();
        
        // スライダーの値が変更されたときのイベントリスナーを追加
        BGMSlider.onValueChanged.AddListener(OnBGMSliderValueChanged);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBGMSliderValueChanged(float value)
    {
        optionManagerScript.SetBGMVolume(value);
        bgmVolumTextScript.UpdateVolumeText(value);
        BGMSlider.value = value;
    }
}
