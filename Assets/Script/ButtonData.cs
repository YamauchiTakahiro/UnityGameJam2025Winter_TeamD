using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonData : MonoBehaviour
{
    [SerializeField] GameObject player;
    //‰Ÿ‚µ‚½‚Æ‚«‚ÉŒÄ‚Î‚ê‚éŠÖ”
    public void OnClick()
    {
        //Player‚Ì¢Š«
        PlayerSpawn();
    }
    void PlayerSpawn()
    {
        float y = Random.Range(-1.6f, -1.1f);
        Instantiate(player, new Vector3(7.0f, y, 0.0f), transform.rotation);
    }
}
