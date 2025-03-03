using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Menu : MonoBehaviour
{

    [SerializeField] public GameObject canvas;
    [SerializeField] public Movement script;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            canvas.SetActive(!canvas.activeSelf);
        }
        if(canvas.activeSelf)
        {
            script.enabled = !script.enabled;
        }
    }   
}