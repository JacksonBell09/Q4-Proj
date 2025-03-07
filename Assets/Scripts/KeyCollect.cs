using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class keycollect : MonoBehaviour
{
    public int score = 0;
    public bool CharacterHasREDKey;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("redkey"))
        {
            CharacterHasREDKey = true;
            Debug.Log("RedKeyCollected");
            Destroy(other.gameObject);
        }
    }
}
