using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSummonScript : MonoBehaviour
{
    [SerializeField] GameObject[] PlayerCharacter;

    public bool[] isSummoned;

    public float[] summonCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SummonCharacter(int i)
    {
        if (i == 0)
        {
            Instantiate(PlayerCharacter[0], transform.position, Quaternion.identity);
            isSummoned[0] = true;
            yield return new WaitForSeconds(summonCount[0]);
            isSummoned[0] = false;
        }
        else if(i == 1)
        {
            Instantiate(PlayerCharacter[1], transform.position, Quaternion.identity);
            isSummoned[1] = true;
            yield return new WaitForSeconds(summonCount[1]);
            isSummoned[1] = false;
        }
    }
}
