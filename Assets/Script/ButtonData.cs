using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonData : MonoBehaviour
{
    Wallet wallet => Wallet.instance;

    [SerializeField] SpriteRenderer player;

    [SerializeField] int cost;
    [SerializeField] Text costText;

    Button button => GetComponent<Button>();
    bool isclicked = false;
    //プレハブを入れる変数
    [SerializeField] GameObject playerPrefab;

    [SerializeField] Slider gaugeBar;

    private void Start()
    {
        //価格表示
        costText.text = cost.ToString() + "円";
    }
    private void Update()
    {
        //所持金が足りないときはボタンを押せなくする
        if (!isclicked && wallet.coin >= cost)
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
    //押したときに呼ばれる関数
    public void OnClick()
    {
        //所持金を減らす
        wallet.coin -= cost;
        //Playerの召喚
        PlayerSpawn();

        //ボタンを押したフラグを立てる
        isclicked = true;
        //ゲージの更新
        StartCoroutine(SliderUpdate()); 
    }
    void PlayerSpawn()
    {

        float y = Random.Range(-1.6f, -1.1f);

        GameObject obj = Instantiate(
           playerPrefab,
           new Vector3(7.0f, y, 0.0f),
           Quaternion.identity
        );

        SpriteRenderer pl = obj.GetComponent<SpriteRenderer>();
        pl.sortingOrder = (int)(-y * 10);
    }
    
    IEnumerator SliderUpdate()
    {
        //ゲージを表示
        gaugeBar.value = 0;
        gaugeBar.gameObject.SetActive(true);

        //時間経過でゲージを増やす
        while (gaugeBar.value < gaugeBar.maxValue)
        {
            gaugeBar.value++;
            yield return new WaitForSeconds(0.1f);
        }

        //ゲージを非表示
        gaugeBar.gameObject.SetActive(false);

        //ボタンを押したフラグを下ろす
        isclicked = false;

    }

}
