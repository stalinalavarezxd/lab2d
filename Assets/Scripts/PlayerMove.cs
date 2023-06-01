using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumpSpeed = 3;
    Rigidbody2D rb2D;

    public bool betterJump = false;
    public float falMultipiler = 0.5f;
    public float lowJumpMultipilier = 1f;
    //public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right") )
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            //spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            //spriteRenderer.flipX = true;

        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
        if (Input.GetKey("space") && CheckGround.isGrounded){
            rb2D.velocity= new Vector2(rb2D.velocity.x,jumpSpeed);
        }
        if (betterJump)
        {
            if (rb2D.velocity.y < 0)
            {
                rb2D.velocity += Vector2.up * Physics.gravity.y * (falMultipiler);
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics.gravity.y * (lowJumpMultipilier);

            }
        }
    }
}
