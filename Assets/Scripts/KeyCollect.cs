using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class keycollect : MonoBehaviour
{
    public int score = 0;
    public bool CharacterHasREDKey;
    public bool CharacterHasBLUEKey;
    public bool CharacterHasGREENKey;
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
    }
}
