using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAbility : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveinput;
    void Start()
    {
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        moveinput.x = Input.GetAxisRaw("Horizontal");
        moveinput.y = Input.GetAxisRaw("Vertical");
        moveinput.Normalize();

        rb.velocity = moveinput * moveSpeed;
    }
}
