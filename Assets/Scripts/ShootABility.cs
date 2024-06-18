using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootABility : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject Bullet;
   


    // Update is called once per frame
   void Update()
   {
        if (Input.GetKeyDown(KeyCode.F))
        {
         Instantiate(Bullet, bulletSpawn.position, bulletSpawn.rotation);
          
        }
        
   }
}
