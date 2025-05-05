using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class RedDoorL3 : MonoBehaviour
{
   // [SerializeField] public GameObject Player;
   [SerializeField] private GameObject canvas;

    public void OnTriggerEnter2D(Collider2D other)
    {
             if(other.gameObject.CompareTag("reddoor3"))
            {
          if (gameObject.GetComponent<keycollect>().CharacterHasREDKey)
        {
            transform.position = new Vector3 (-500.94f, 75.85f, 0f);
            Debug.Log("teleporting...");
        }
        else
        {
            canvas.SetActive(true);
            StartCoroutine(redDoors3());
        }
            }
    }
    
     
    public IEnumerator redDoors3()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
