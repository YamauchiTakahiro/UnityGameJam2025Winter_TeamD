using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BgmVolumTextScript : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI bgmVolumText;


    // Start is called before the first frame update
    void Start()
    {
        float volume;
        if(PlayerPrefs.HasKey("BGMVolume"))
        {
            volume = PlayerPrefs.GetFloat("BGMVolume", 0.5f);
        }
        else
        {
            volume = 0.5f;
        }
        bgmVolumText.text = (volume * 100).ToString("0")+"%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateVolumeText(float volume)
    {
        bgmVolumText.text = (volume * 100).ToString("0")+"%";
    }
}
