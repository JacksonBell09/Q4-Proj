using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class BlueDoorL1 : MonoBehaviour
{
   // [SerializeField] public GameObject Player;
   [SerializeField] private GameObject canvas;

    public void OnTriggerEnter2D(Collider2D other)
    {
             if(other.gameObject.CompareTag("bluedoor"))
            {
          if (gameObject.GetComponent<keycollect>().CharacterHasBLUEKey)
        {
           SceneManager.LoadScene("2");
        }
        else
        {
            canvas.SetActive(true);
            StartCoroutine(bluedoors());
        }
            }
    }
    
     
    public IEnumerator bluedoors()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
