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

    //攻撃アニメーション用　Animator anim;
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
        //攻撃アニメーション２　anim = GetComponent<Animator>();
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
            //攻撃開始　攻撃アニメーションの再生
            // 攻撃アニメーション３　anim.SetBool("Attack", true);
            //相手のHPを削る
            HPScript hpScript = collision.gameObject.GetComponent<HPScript>();
            StartCoroutine(AttackAction(hpScript));
        }
        

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
    IEnumerator AttackAction(HPScript hpScript)
    {
        while (hpScript.hp > 0)
        {
           yield return new WaitForSeconds(0.5f);
            if(hpScript.hp > 0)
            {
                hpScript.Damage(1);
            }
            
        }
    }

    public void DestroyEvent()
    {
        Destroy(gameObject);
    }
}
