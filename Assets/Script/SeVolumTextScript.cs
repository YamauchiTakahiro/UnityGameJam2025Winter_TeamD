using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeVolumTextScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI seVolumText;
    // Start is called before the first frame update
    void Start()
    {
        float volume;

        if (PlayerPrefs.HasKey("SeVolume"))
        {
            volume = PlayerPrefs.GetFloat("SeVolume", 0.5f);
        }
        else
        {
            volume = 0.5f;
        }
        seVolumText.text = (volume * 100).ToString("0") + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateVolumeText(float volume)
    {
        seVolumText.text = (volume * 100).ToString("0") + "%";
    }
}
