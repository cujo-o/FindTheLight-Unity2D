using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float Horizontal;
  
    public bool isfacingright;

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Flip();
    }
    void Flip()
    {
        if (isfacingright && Horizontal < 0f || !isfacingright && Horizontal > 0f)
        {
            isfacingright = !isfacingright;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
            transform.Rotate(0, 180, 0);
        }
    }
}
