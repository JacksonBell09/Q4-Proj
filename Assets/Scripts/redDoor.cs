using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class redDoor : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<keycollect>().CharacterHasREDKey)
            {
                SceneManager.LoadScene("2");
            }
            else
            {
                canvas.SetActive(true);
                StartCoroutine(redDoors());
            }
        }
    
    }
    IEnumerator redDoors()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
