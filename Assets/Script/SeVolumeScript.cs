using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeVolumeScript : MonoBehaviour
{
    [SerializeField] GameObject OptionManager;
    OptionManagerScript optionManagerScript;

    [SerializeField] GameObject SeVolumeText;
    SeVolumTextScript SeVolumTextScript;


    [Header("SE音量設定スライダー")]
    [SerializeField] private Slider SeSlider;

    public void Awake()
    {
        optionManagerScript = OptionManager.GetComponent<OptionManagerScript>();
        SeSlider.value = optionManagerScript.GetSeVolume();
        SeVolumTextScript = SeVolumeText.GetComponent<SeVolumTextScript>();

        // スライダーの値が変更されたときのイベントリスナーを追加
        SeSlider.onValueChanged.AddListener(OnSeSliderValueChanged);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnSeSliderValueChanged(float value)
    {
        optionManagerScript.SetSeVolume(value);
        SeVolumTextScript.UpdateVolumeText(value);
        SeSlider.value = value;
    }
}

