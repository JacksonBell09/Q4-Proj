using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float EnemySpeed = 5.0f;
    public GameObject[] wayPoints;
    private int currentWayPoint;

    public bool isChasing;
    public float distanceBetween;
    public GameObject Player;
    private float distance;

   //Section: basic movement, chase script, and waypoint script.
    // Update is called once per frame
    void Update()
    {

        distanceBetween = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 

        if(distanceBetween < 15)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, EnemySpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
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
        //End of previous section

        //Section: Animation Logic
        if (verticleInput >= 0)
        {
            animator.setbool("IsMovingUp", IsMovingUp);
        }

        if (verticleInput <= 0)
        {
            animator.setbool("IsMovingDown", IsMovingDown);
        }

        if (horizontalInput >= 0)
        {
            animator.setbool("IsMovingRight", IsMovingRight);
        }

        if (horizontalInput <= 0)
        {
            animator.setbool("IsMovingLeft", IsMovingLeft);
        }
        //End of previous section
    }
}