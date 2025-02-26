using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class coin : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            score++;
            UpdateScore();
            Destroy(other.gameObject);
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Coins: " + score;
    }
}
