using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Character : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private float moveSpeed;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;

        if (CrossPlatformInputManager.GetButtonDown("Jump") && rb.velocity.y == 0)
            rb.AddForce(Vector2.up * 700);

        if (Mathf.Abs(dirX) > 0 && rb.velocity.y == 0)
        {
           // Debug.Log("VElocity Given");
            anim.SetBool("isRunning", true);

        }
        else
            anim.SetBool("isRunning", false);

        if (rb.velocity.y == 0)
        {
            anim.SetBool("isJumping", false);
          //  anim.SetBool("isFalling", false);
        }

        if (rb.velocity.y > 0)
            anim.SetBool("isJumping", true);

        if (rb.velocity.y < 0)
        {
            anim.SetBool("isJumping", false);
           // anim.SetBool("isFalling", true);
        }
    }
         private void FixedUpdate()
        {
            rb.velocity = new Vector2(dirX, rb.velocity.y);
        }

        private void LateUpdate()
        {
            if (dirX > 0)
                facingRight = false;
            else if (dirX < 0)
                facingRight = true;

            if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
                localScale.x *= -1;

            transform.localScale = localScale;
        }
    
}