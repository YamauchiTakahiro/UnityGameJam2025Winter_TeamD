using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummonButtonScript : MonoBehaviour
{
    Button summonButton;

    [SerializeField] GameObject CharacterSummon;

    CharacterSummonScript characterSummonScript;

    public int characterId;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SummonButton()
    {
        summonButton = GetComponent<Button>();
        characterSummonScript = CharacterSummon.GetComponent<CharacterSummonScript>();
        summonButton.onClick.AddListener(() =>
        {
            if (characterSummonScript.isSummoned[characterId] == false)
            {
                StartCoroutine(characterSummonScript.SummonCharacter(characterId));
            }
        });
    }
}
