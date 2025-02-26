using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class speednode : MonoBehaviour
{
    public float moveSpeed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("speednode"))
        {
            moveSpeed+=5f;
            StartCoroutine(Speednode(other));
        }
    }
    IEnumerator Speednode(Collider2D Player)
    {
        yield return new WaitForSeconds(5);
        moveSpeed-=5f;
    }
}
