using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// jackson Bell
public class Movement : MonoBehaviour
{
    public float movespeed = 5f;
    private Rigidbody2D rb;
    public float Stamina = 100f;
    public TMP_Text StaminaText;
    public bool CharacterIsRunning;
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
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector2 moveVector = new Vector2 (horizontalInput * movespeed, verticalInput * movespeed);
        //player is jumping
        rb.velocity = moveVector;
        if (Input.GetKeyDown(KeyCode.LeftShift) && (Stamina > 0))
        {
            movespeed +=5f;
        }
        if (Input.GetKey(KeyCode.LeftShift) && (Stamina > 0)&& ((horizontalInput != 0) || (verticalInput != 0)))
        {
            CharacterIsRunning = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)){
            CharacterIsRunning = false;
            movespeed =5f;
        }
        if (CharacterIsRunning)
        {
            if(Stamina > 0)
            {
                Stamina -= 20 * Time.deltaTime;
            }
            
        }
        else
        {
            if(Stamina < 100 && !CharacterIsRunning)
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
        if (Stamina <= 0)
        {
            movespeed = 5f;
        }
        StaminaText.text = "Stamina: " +  (int)Stamina;
    }
}
