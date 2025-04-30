using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class BlueDoorL2 : MonoBehaviour
{
   // [SerializeField] public GameObject Player;
   [SerializeField] private GameObject canvas;

    public void OnTriggerEnter2D(Collider2D other)
    {
             if(other.gameObject.CompareTag("bluedoor2"))
            {
          if (gameObject.GetComponent<keycollect>().CharacterHasBLUEKey2)
        {
           SceneManager.LoadScene("3");
        }
        else
        {
            canvas.SetActive(true);
            StartCoroutine(bluedoors2());
        }
            }
    }
    
     
    public IEnumerator bluedoors2()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
