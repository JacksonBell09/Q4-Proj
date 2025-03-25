using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float EnemySpeed = 5.0f;
    public GameObject[] wayPoints;
    private int currentWayPoint;

    public Transform playerTransform;
    public bool isChasing;
    public float chaseDistance;

    // Update is called once per frame
    void Update()
    {
        isChasing = Vector2.Distance(transform.position, playerTransform.position) < chaseDistance;
        if (isChasing)
        {
            if (transform.position.x > playerTransform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
                transform.position += Vector3.left * EnemySpeed * Time.deltaTime;
            }
            if (transform.position.x < playerTransform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.position += Vector3.right * EnemySpeed * Time.deltaTime;
            }
            //for the Y axis
            if (transform.position.y > playerTransform.position.y)
            {
                transform.localScale = new Vector3(1, 1, 1);
                transform.position += Vector3.up * EnemySpeed * Time.deltaTime;
            }
            if (transform.position.y < playerTransform.position.y)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.position += Vector3.down * EnemySpeed * Time.deltaTime;
            }
        }
        else
        {

        if(Vector2.Distance(wayPoints[currentWayPoint].transform.position, transform.position) < .1f)   
        {
            currentWayPoint++;
            transform.Rotate(0, 180f, 0);
            if(currentWayPoint >= wayPoints.Length)
            {
                currentWayPoint = 0;
            }
        }
         transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime * EnemySpeed);
        }
    }
}
