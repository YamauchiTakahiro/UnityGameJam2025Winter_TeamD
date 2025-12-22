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
    // BGM音量設定
    //使い方
    // オプション画面でBGM音量を設定する際に、SetBGMVolumeメソッドを呼び出して音量を保存します。
    // ゲーム起動時やオプション画面表示時に、GetBGMVolumeメソッドを呼び出して保存された音量を取得します。
    // 例:
    // optionManagerScript.SetBGMVolume(0.8f); // BGM音量を0.8に設定
    // float currentBGMVolume = optionManagerScript.GetBGMVolume(); // 保存されたBGM音量を取得
    // PlayerPrefsを使用して音量設定を保存するため、ゲームを再起動しても設定が保持されます。
    // BGM音量は0.0から1.0の範囲で設定してください。
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
