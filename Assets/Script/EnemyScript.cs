using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public enum TYPE
    {
        en_Player,
        en_Enemy,
        en_Num
    }
    public TYPE type = TYPE.en_Player;

    Vector3 pos;
    float direction;
    bool isMove = true;
    // Start is called before the first frame update
    void Start()
    {
        switch(type)
        {
            case TYPE.en_Player:
                //playerの処理
                direction = -0.5f;
                break;
            case TYPE.en_Enemy:
                //enemyの処理
                direction = 0.5f;
                break;

        }
        pos = new Vector3(direction, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove)
        {
            transform.position += pos * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //もしEnemyのタグかつPlayerタイプなら
        //またはPlayerのタグかつEnemyタイプなら
        if (collision.gameObject.tag == "Enemy" && type == TYPE.en_Player || collision.gameObject.tag == "Player" && type == TYPE.en_Enemy)
        {
            //動きを止める
            isMove = false;
        }
        //攻撃開始
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //もしEnemyのタグかつPlayerタイプなら
        //またはPlayerのタグかつEnemyタイプなら
        if (collision.gameObject.tag == "Enemy" && type == TYPE.en_Player || collision.gameObject.tag == "Player" && type == TYPE.en_Enemy)
        {
            //動きを再開する
            isMove = true;
        }
    }
}
