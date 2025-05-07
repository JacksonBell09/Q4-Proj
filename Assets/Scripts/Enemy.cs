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
    public Animator animator;

   //Section: basic movement, chase script, and waypoint script.
    // Update is called once per frame
    void Update()
    {

        distanceBetween = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 

        Vector2 oldPosition; //this stores our initial position before update (remember this when you get to the end of this section)
        Vector2 animCheck = new Vector2(0f,0f); //this is a variable that we're using to check every update

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
            oldPosition = transform.position; //the old position is defined here
            transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime * EnemySpeed);
            animCheck = new Vector2(transform.position.x, transform.position.y) - oldPosition; //this is checking our current position, and then subtracting our old pos.
            //By doing this, we're finding our change in position since the last update, if our previous.pos = 0, and our new.pos = 1, 4, then our change was 1,4, we're moving up and right.
        }
        //End of previous section

        //Section: Animation Logic
        if (animCheck.y >= 0)
        {
            animator.SetBool("IsMovingUp", true); //character is moving up
            animator.SetBool("IsMovingDown", false);//therefore it cannot be moving down (remember the logan analogy)
        }

        if (animCheck.y <= 0)
        {
            animator.SetBool("IsMovingDown", true);
            animator.SetBool("IsMovingUp", false);
        }

        if (animCheck.x >= 0)
        {
            animator.SetBool("IsMovingRight", true);
            animator.SetBool("IsMovingLeft", false);
        }

        if (animCheck.x <= 0)
        {
            animator.SetBool("IsMovingLeft", true);
            animator.SetBool("IsMovingRight", false);
        }
        //End of previous section
    }
}