using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUI : MonoBehaviour
{
    [SerializeField] Text hpText;
    [SerializeField] HPScript hpScript;

    int maxHp;
    int Hp;
    // Start is called before the first frame update
    void Start()
    {
        maxHp = hpScript.hp;
        Hp = maxHp;
        UpdateUI();
    }

    public void UpdateUI()
    {
        Hp = hpScript.hp;
        if (Hp <= 0)
        {
            Hp = 0;
        }
        hpText.text = Hp.ToString() + "/" + maxHp.ToString();
    }

  
}
