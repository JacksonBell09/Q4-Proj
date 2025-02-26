using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    public void Transition()
    {
        SceneManager.LoadScene("Level2");
    }
}
