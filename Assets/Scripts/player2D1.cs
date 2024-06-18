using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2D : MonoBehaviour
{
    public float Horizontal;
    public float Speed;
    public float JumpForce;
    public bool isfacingright;

    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public TrailRenderer tr;

     private bool canDash = true;
    private bool isDashing = false;
    public float dashingPower;
    public float dashingTime;
    public float dashingCooldown;

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && Isgrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
        }

        if (Input.GetButtonDown("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
          

        }
        if (Input.GetKeyDown(KeyCode.Z) && canDash)
        {
            StartCoroutine(Dash());
        }
        if (isDashing)
        {
            return;
        }



        Flip();
    }

    void FixedUpdate()
    { if (isDashing)
        {
            return;
        }

        rb.velocity = new Vector2(Horizontal * Speed, rb.velocity.y);
    }
    private bool Isgrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    void Flip()
    {
        if (isfacingright && Horizontal < 0f || !isfacingright && Horizontal > 0f)
        {
            isfacingright = !isfacingright;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
          
        }
    }
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}
