using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class BlueDoorL3 : MonoBehaviour
{
   // [SerializeField] public GameObject Player;
   [SerializeField] private GameObject canvas;

    public void OnTriggerEnter2D(Collider2D other)
    {
             if(other.gameObject.CompareTag("bluedoor3"))
            {
          if (gameObject.GetComponent<keycollect>().CharacterHasBLUEKey3)
        {
           SceneManager.LoadScene("victory");
        }
        else
        {
            canvas.SetActive(true);
            StartCoroutine(bluedoors3());
        }
            }
    }
    
     
    public IEnumerator bluedoors3()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
