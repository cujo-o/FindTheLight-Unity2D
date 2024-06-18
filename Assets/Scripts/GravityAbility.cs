using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAbility : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Physics2D.gravity = new Vector2(0f, 9.81f);
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            Physics2D.gravity = new Vector2(0f, -9.81f);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Physics2D.gravity = new Vector2(150f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            Physics2D.gravity = new Vector2(-150f, 0f);
        }

    }
}
