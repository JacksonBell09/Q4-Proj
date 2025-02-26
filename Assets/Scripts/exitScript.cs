using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitGame()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
