using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GreenDoorL2 : MonoBehaviour
{
   // [SerializeField] public GameObject Player;
   [SerializeField] private GameObject canvas;

    public void OnTriggerEnter2D(Collider2D other)
    {
             if(other.gameObject.CompareTag("greendoor2"))
            {
          if (gameObject.GetComponent<keycollect>().CharacterHasGREENKey2)
        {
            transform.position = new Vector3 (154.8f, -169.5f, -0.3968597f);
            Debug.Log("teleporting...");
        }
        else
        {
            canvas.SetActive(true);
            StartCoroutine(greendoors2());
        }
            }
    }
    
     
    public IEnumerator greendoors2()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
