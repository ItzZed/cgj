using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float jumpForce;
    private float mInput;

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private bool facingRight = true;
    private int jumpsLeft;
    public int jumpsAllowed;


    void Start() {

        jumpsLeft = jumpsAllowed;
        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate() {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        mInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(mInput * speed, rb.velocity.y);

        // If Player Right then Flip Right; If Player Left then Flip Left
        if(facingRight == false && mInput > 0) {

            Flip();

        }
        else if(facingRight == true && mInput < 0) {

            Flip();

        }

    }

    void Update() {

        if(isGrounded) {

            // Reset Jumps
            jumpsLeft = jumpsAllowed;
        }

        // Jump Handler
        if(Input.GetKeyDown(KeyCode.UpArrow) && jumpsLeft > 0) {

            rb.velocity = Vector2.up * jumpForce;
            jumpsLeft--;

        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && jumpsLeft == 0 && isGrounded == true) {

            rb.velocity = Vector2.up * jumpForce;

        }

    }

    // Flip Player
    void Flip() {

        facingRight = !facingRight;
        Vector3 Scalar = transform.localScale;
        Scalar.x *= -1;
        transform.localScale = Scalar;

    }

}
