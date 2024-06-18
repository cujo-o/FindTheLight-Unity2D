using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAbility : MonoBehaviour
{
   
    public bool canDash = true;
    private bool isDashing;
    public float dashingPower;
    public float dashingTime ;
    public float dashingCooldown;

   public Rigidbody2D rb;
  
   public TrailRenderer tr;

    public void update()
    {
        if (isDashing)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.B) && canDash)
        {
            StartCoroutine(Dash());
            Debug.Log("its working");
        }
    }

  public IEnumerator Dash()
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

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
    }

}
