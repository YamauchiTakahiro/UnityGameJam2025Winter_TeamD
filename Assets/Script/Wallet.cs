using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public static Wallet instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    /** テキストを宣言するところ */
    [SerializeField] Text coinText;

    public int coinLevel;
    [SerializeField] int[] maxCoin; // 最大所持金額
    public float coin  = 0; // 所持金額

   public int coinSpeed = 6; // コインの増える速度
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = coin.ToString() + "/" + maxCoin[coinLevel].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManagerScript.instance.isGame && coin <= maxCoin[coinLevel])
        {
            //時間経過でコインが増える 
            coin += Time.deltaTime * coinSpeed;
            coinText.text = coin.ToString("F0") + "/" + maxCoin[coinLevel].ToString();
        }
    }
}
