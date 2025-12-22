using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    Wallet wallet => Wallet.instance;

    [SerializeField] Text levelText;
    [SerializeField] Text costText;

    int level = 1;
    [SerializeField] int[] cost;

    Button  button => GetComponent<Button>();

    bool isMax = false;

    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "Level " + level.ToString();
        costText.text = cost[level - 1].ToString() + "円";
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMax)
        {
            //レベルアップ可能か判定
            if (wallet.coin >= cost[level - 1])
            {
                //ボタンを押せるようにする
                button.interactable = true;
            }
            else
            {
                //ボタンを押せないようにする
                button.interactable = false;
            }
        }
    }

    public void OnClick()
    {
        if (level >= cost.Length)
        {
            //最大レベルに達した
            isMax = true;
            //最大レベルに達していたら何もしない
            costText.text = "MAX";
            levelText.gameObject.SetActive(false);
            button.interactable = true;
            button.enabled = false;
        }
        else
         {


            //必要な金額分所持金を減らす
            wallet.coin -= cost[level - 1];

            //レベルアップ
            level++;

            //金額のスピードを上げる
            wallet.coinSpeed += 3;

            //テキストの表示を変更する
            levelText.text = "Level " + level.ToString();
            costText.text = cost[level - 1].ToString() + "円";

            //最大所持金額を増やす
            wallet.coinLevel++;
        }
    }
}
