using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] SpriteRenderer[] enemys;
   // [SerializeField] GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //一定間隔で敵を出すコルーチンを開始
        StartCoroutine(EnemyCasleSpawn());
    }

    //一定間隔で出せるようにする
    IEnumerator EnemyCasleSpawn()
    {
        yield return new WaitForSeconds(5.0f);
        //isGameがtrueの間繰り返す
        while (GameManagerScript.instance.isGame)
        {
            int r = Random.Range(0, enemys.Length);
            float y = Random.Range(-1.6f, -1.1f);
            SpriteRenderer enemy = Instantiate(enemys[r], new Vector3(-7.0f, y, 0.0f), transform.rotation);
            enemy.sortingOrder = (int)(-y * 10);

            yield return new WaitForSeconds(10.0f);
        }
      
    }
}
