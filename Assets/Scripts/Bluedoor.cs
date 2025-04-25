using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class blueDoor : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<keycollect>().CharacterHasBLUEKey)
            {
                SceneManager.LoadScene("2");
            }
            else
            {
                canvas.SetActive(true);
                StartCoroutine(blueDoors());
            }
        }
    
    }
    IEnumerator blueDoors()
    {
        yield return new WaitForSeconds(5);
        canvas.SetActive(false);
    }
}
