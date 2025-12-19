using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManagerScript : MonoBehaviour
{
    [SerializeField] GameObject BgmVolumeScript;
    BgmVolumeScript bgmVolumeScript;
    [SerializeField] GameObject SeVolumeScript;
    SeVolumeScript seVolumeScript;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBGMVolume(float volume)
    {
        PlayerPrefs.SetFloat("BGMVolume", volume);
    }
    public float GetBGMVolume()
    {
        return PlayerPrefs.GetFloat("BGMVolume", 0.5f);
    }

    public void SetSeVolume(float volume)
    {
        PlayerPrefs.SetFloat("SeVolume", volume);
    }

    public float GetSeVolume()
    {
        return PlayerPrefs.GetFloat("SeVolume", 0.5f);
    }
}
