using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class keycollect : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    public int score = 0;
    public bool CharacterHasREDKey;
    public bool CharacterHasBLUEKey;
    public bool CharacterHasGREENKey;
    public bool CharacterHasREDKey2;
    public bool CharacterHasBLUEKey2;
    public bool CharacterHasGREENKey2;
    public bool CharacterHasREDKey3;
    public bool CharacterHasBLUEKey3;
    public bool CharacterHasGREENKey3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("redkey"))
        {
            CharacterHasREDKey = true;
            Debug.Log("RedKeyCollected");
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("bluekey"))
        {
            CharacterHasBLUEKey = true;
            Debug.Log("BlueKeyCollected");
            Destroy(other.gameObject);
        }
         if(other.gameObject.CompareTag("greenkey"))
        {
            CharacterHasGREENKey = true;
            Debug.Log("GreenKeyCollected");
            Destroy(other.gameObject);
        }
            if(other.gameObject.CompareTag("redkey2"))
            {
                CharacterHasREDKey2 = true;
                Debug.Log("RedKeyCollected");
                Destroy(other.gameObject);
            }
            if(other.gameObject.CompareTag("bluekey2"))
            {
                CharacterHasBLUEKey2 = true;
                Debug.Log("BlueKeyCollected");
                Destroy(other.gameObject);
            }
            if(other.gameObject.CompareTag("greenkey2"))
            {
                CharacterHasGREENKey2 = true;
                Debug.Log("GreenKeyCollected");
                Destroy(other.gameObject);
            }
                    if(other.gameObject.CompareTag("redkey3"))
                {
                    CharacterHasREDKey3 = true;
                    Debug.Log("RedKeyCollected");
                    Destroy(other.gameObject);
                }
                if(other.gameObject.CompareTag("bluekey3"))
                {
                    CharacterHasBLUEKey3 = true;
                    Debug.Log("BlueKeyCollected");
                    Destroy(other.gameObject);
                }
                if(other.gameObject.CompareTag("greenkey3"))
                {
                    CharacterHasGREENKey3 = true;
                    Debug.Log("GreenKeyCollected");
                    Destroy(other.gameObject);
                }
        }
    }

