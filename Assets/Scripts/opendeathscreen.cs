using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class opoendeathscreen : MonoBehaviour
{

    [SerializeField] private GameObject canvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("deathbar"))
        {
            canvas.SetActive(true);
        }
    }
}