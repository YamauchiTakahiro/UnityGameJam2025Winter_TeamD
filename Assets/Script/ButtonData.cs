using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonData : MonoBehaviour
{
    [SerializeField] SpriteRenderer player;
    [SerializeField] GameObject playerPrefab;
    //‰Ÿ‚µ‚½‚Æ‚«‚ÉŒÄ‚Î‚ê‚éŠÖ”
    public void OnClick()
    {
        //Player‚Ì¢Š«
        PlayerSpawn();
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

   }
