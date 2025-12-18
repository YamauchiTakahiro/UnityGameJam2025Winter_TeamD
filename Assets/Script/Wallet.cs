using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    /** テキストを宣言するところ */
    [SerializeField] Text coinText;

    int maxCoin = 10000; // 最大所持金額
    float coin  = 0; // 所持金額
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = coin.ToString() + "/" + maxCoin.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
