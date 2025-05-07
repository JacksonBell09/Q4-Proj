using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// jackson Bell
public class Movement : MonoBehaviour
{ 
    public bool Moving;
    public float movespeed = 5f;
    private Rigidbody2D rb;
    public float Stamina = 100f;
    public TMP_Text StaminaText;
    public bool CharacterIsRunning;
    public Animator animator;
    //start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }

//update is called once per frame
    void Update()
    {
        //code for horizontal movement
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        
        if(horizontalInput <= 0)
        {
        transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(horizontalInput >= 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector2 moveVector = new Vector2 (horizontalInput * movespeed, verticalInput * movespeed);
        //player is jumping
        rb.velocity = moveVector;


        animator.SetFloat("X", horizontalInput);
        animator.SetFloat("Y", verticalInput);
        

            if(horizontalInput != 0 || verticalInput !=0);
            {
                Moving = true;
            }
 
        animator.SetBool("Moving", true);

        




        if (Input.GetKeyDown(KeyCode.LeftShift) && (Stamina > 0)) //checks for left shift
        {
            movespeed +=5f;
        }
        if (Input.GetKey(KeyCode.LeftShift) && (Stamina > 0) && ((horizontalInput != 0) || (verticalInput != 0))) //checks if left shift is pressed, stamina is above 0, and move inputs are or are not = 0
        {
            CharacterIsRunning = true; //sets our bool CharacterIsRunning to true
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)){ //does the opposite of keydown
            CharacterIsRunning = false; //sets character running to false if the key is not being pressed
            movespeed =5f;
        }
        if (CharacterIsRunning)
        {
            if(Stamina > 0)
            {
                Stamina -= 20 * Time.deltaTime; //after checking if character is running, stamina will be depleted over time
            }
            
        }
        else
        {
            if(Stamina < 100 && !CharacterIsRunning)  //this is just logic for making the stamina work
            {
                if(!(Stamina + (5 * Time.deltaTime) >100))
                {
                    Stamina += 5 * Time.deltaTime;
                }
                else
                {
                    Stamina = 100;
                }
                
            }
        }
        if (Stamina <= 0) //more logic because im a bad coder
        {
            movespeed = 5f;
        }
        StaminaText.text = "Stamina: " +  (int)Stamina;
    }
}
