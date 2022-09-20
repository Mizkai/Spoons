using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController : MonoBehaviour
{
    //These are variables!
   
    //Speed of character movement and height of the jump. Set these values in the inspector.
    public float speed;
    // public float jumpHeight;

    //Assigning a variable where we'll store the Rigidbody2D component.
    private Rigidbody2D rb;
    //Animation
    // private Animator animator;
    // private bool canDoubleJump;
    // private bool isGrounded;
    // SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        //Sets our variable 'rb' to the Rigidbody2D component on the game object where this script is attached.
        rb = GetComponent<Rigidbody2D>();
        // //Animator
        // animator = GetComponent<Animator>();
        // sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {  
        // if (isGrounded)
        // {
        //     canDoubleJump = true;
        // }
        //If we're able to jump and the player has pressed the space bar, then we jump!
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     if (isGrounded)
        //     {
        //         float jumpHeight = 5f;
        //         rb.velocity = Vector2.up * jumpHeight;
        //         jumpSound.Play(); 
        //         canDoubleJump = true;
        //     }

        //     else
        //     {
        //         if (canDoubleJump)
        //         {
        //             jumpSound.Play(); 
        //         float jumpHeight = 5f;
        //         rb.velocity = Vector2.up * jumpHeight;
                
        //         canDoubleJump = false;
        //         }
        //     }
        // }
        //This is our movement function that checks for key presses, and updates the rigidbody's velocity accordingly
        UpdateVelocity();

    }
    

    #region Movement
    private void UpdateVelocity()
    {
        //declare a new Vector2 (an x direction and a y direction), and set it equal to the rigidbody's current velocity
        Vector2 newVelocity = rb.velocity; 

        if (Input.GetKey(KeyCode.LeftArrow)) //If we are pressing the left arrow
        {
            newVelocity.x = -speed; //set to x value to be negative speed (because speed is a number)
            // animator.SetBool("IsMoving", true);
            // sprite.flipX = true;
        }

        else if (Input.GetKey(KeyCode.RightArrow)) // If you are pressing the right arrow
        {
            newVelocity.x = speed; //Set the x value to be speed
            
            // animator.SetBool("IsMoving", true);//animator
            // sprite.flipX= false;
        }
        
        else //If we are not pressing either the left or right arrow keys...
        {
            newVelocity.x = 0; // remove velocity
            
            // animator.SetBool("IsMoving", false);//animator
        }

        //When we've worked out what the velocity should be, we write the value back onto our rigidbody so it will move
        rb.velocity = newVelocity;
    }

    #endregion

    #region collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If we collide with an object tagged "ground" then our jump resets and we can now jump.
        // if (collision.gameObject.tag == "ground")
        // {
        //     isGrounded = true;
        //     //print statements print to the Console panel in Unity. 
        //     //This will print the value of onGround, which is a boolean, so either True or False.
        // }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // //If we exit our collision with the "ground" object, then we are unable to jump.
        // if (collision.gameObject.tag == "ground")
        // {
        //     isGrounded = false;
        // }
    }
    #endregion

}
