using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSummonScript : MonoBehaviour
{
    [SerializeField] GameObject[] PlayerCharacter;

    public bool isSummoned = false;

    public float[] summonCount;

    public int characterIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SummonCharacter()
    {
        Instantiate(PlayerCharacter[characterIndex], transform.position, Quaternion.identity);

        isSummoned = true;

        yield return new WaitForSeconds(summonCount[characterIndex]);

        isSummoned = false;         
    }
}
