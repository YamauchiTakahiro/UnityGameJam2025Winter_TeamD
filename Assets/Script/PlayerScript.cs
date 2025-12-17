using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float speed = 0.0f;
    private Rigidbody2D movePlayer;
    // Start is called before the first frame update
    void Start()
    {
        movePlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        if(movePlayer != null)
        {
            movePlayer.velocity = new Vector2(speed, movePlayer.velocity.y);
        }
    }
}
