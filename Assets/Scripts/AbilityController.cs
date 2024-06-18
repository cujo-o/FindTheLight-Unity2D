using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class AbilityController : MonoBehaviour
{
    public player2D baseForm;
    public ShootABility shootAb;
    public FlyAbility FlyAb;
    public GravityAbility GravAb;

    public ParticleSystem elecricity;
    public ParticleSystem airpt;

   
    public SpriteRenderer bodyColor;

    public GameObject baselight;
    public GameObject bluelight;
    public GameObject redlight;
    public GameObject yellowlight;
    public GameObject greenlight;
   


    // Update is called once per frame
    void Start()
    {
       baseForm = GetComponent<player2D>();
       shootAb = GetComponent<ShootABility>();
       FlyAb = GetComponent<FlyAbility>();
     
       GravAb = GetComponent<GravityAbility>();
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            blue();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            green();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            red();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            yellow();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            baselight.SetActive(false);
            bluelight.SetActive(false); 
            redlight.SetActive(false);
            yellowlight.SetActive(true);
            greenlight.SetActive(false);

            bodyColor.color = Color.yellow;
            elecricity.enableEmission = false;
            airpt.enableEmission = false;
        }

    }
    public void blue()   //shoot
    {


        baselight.SetActive(false);
        bluelight.SetActive(true);
        redlight.SetActive(false);
        yellowlight.SetActive(false);
        greenlight.SetActive(false);

        bodyColor.color = Color.blue;
            baseForm.enabled = true ;
            shootAb.enabled =true ;
            FlyAb.enabled = false;
            elecricity.enableEmission = true;
            GravAb.enabled = false;
            airpt.enableEmission = false;
            
      
    }
    public void green() //gravity
    {
        baselight.SetActive(false);
        bluelight.SetActive(false);
        redlight.SetActive(false);
        yellowlight.SetActive(false);
        greenlight.SetActive(true);

        bodyColor.color = Color.green;
        baseForm.enabled = true;
            shootAb.enabled = false;
            FlyAb.enabled = false;
            elecricity.enableEmission = false;
            GravAb.enabled = true;
        airpt.enableEmission = false;
       
    }
    public void red() //fly
    {
        baselight.SetActive(false);
        bluelight.SetActive(false);
        redlight.SetActive(true);
        yellowlight.SetActive(false);
        greenlight.SetActive(false);

        bodyColor.color = Color.red;
        baseForm.enabled = false;
            shootAb.enabled = false;
            FlyAb.enabled = true;
            elecricity.enableEmission = false;
            GravAb.enabled = false;
            airpt.enableEmission = true;
        
    }

    public void yellow() //Base
    {

       
        {
            baselight.SetActive(true);
            bluelight.SetActive(false);
            redlight.SetActive(false);
            yellowlight.SetActive(false);
            greenlight.SetActive(false);

            bodyColor.color = Color.black;
            baseForm.enabled = true;
            shootAb.enabled = false;
            FlyAb.enabled = false;
            elecricity.enableEmission = false;
            GravAb.enabled = false;
            airpt.enableEmission = false;
            Physics2D.gravity = new Vector2(0,-9.81f);

        }
    }
}
