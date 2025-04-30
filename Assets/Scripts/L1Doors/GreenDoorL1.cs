using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GreenDoorL1 : MonoBehaviour
{
   // [SerializeField] public GameObject Player;
   [SerializeField] private GameObject canvas;

    public void OnTriggerEnter2D(Collider2D other)
    {
             if(other.gameObject.CompareTag("greendoor"))
            {
          if (gameObject.GetComponent<keycollect>().CharacterHasGREENKey)
        {
            transform.position = new Vector3 (154.8f, -169.5f, -0.3968597f);
            Debug.Log("teleporting...");
        }
        else
        {
            canvas.SetActive(true);
            StartCoroutine(greendoors());
        }
            }
    }
    
     
    public IEnumerator greendoors()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
