using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    
    [SerializeField] GameObject SoundManager;
    SoundManagerScript soundManagerScript;
    [SerializeField] GameObject OptionManager;
    OptionManagerScript optionManagerScript;

    private void Awake()
    {
        optionManagerScript = OptionManager.GetComponent<OptionManagerScript>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetBGMVolume();
       // SetSEVolume();
    }

    private void SetBGMVolume()
    {
        float bgmVolume = optionManagerScript.GetBGMVolume();
        AudioListener.volume = bgmVolume;
    }

    private void SetSEVolume()
    {
        float seVolume = optionManagerScript.GetSeVolume();
        AudioListener.volume = seVolume;
    }


}
