using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class HPScript : MonoBehaviour
{
    public int hp;

    [SerializeField] UnityEvent onDamageEvent;
    [SerializeField] UnityEvent onDestroyEvent;

    GameManagerScript gn => GameManagerScript.instance;


    // Update is called once per frame
    public void Damage(int damage)
    {
        if (gn.isGame)
        {
            hp -= damage;


            if (onDamageEvent != null)
            {
                onDamageEvent.Invoke();
            }
            if (hp <= 0)
            {
                if (onDestroyEvent != null)
                {
                    onDestroyEvent.Invoke();
                }
            }

        }
    }
}
