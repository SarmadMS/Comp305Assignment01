using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Source file name:PlayerController
 * Author’s name: Sarmad Siddiqi
 * Last Modified by: Sarmad Siddiqi
 * Date last Modified: October 4th
 * Program description: basic Player movement and fire button as well as handling Player boundry
 * Revison History: 
 * Added Movement
 * Added Boundry
 * Added Fire button
 * Edited Code for Fire button
 * Edited Code for Fire Button
 * 
 * 
 * 
 */
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    //public float bulletspeed = 5.0f;

    public float minY;
    public float maxY;
    public float minX;
    public float maxX;
     public GameObject laser;
   // public Rigidbody2D lasers;
    //public GameObject Blaster;
    public Transform laserSpawn;
     public float fireRate = 8.0f;

    // Private Variables
    private Rigidbody2D rBody;
    private float counter = 0.0f;

    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

   

void Update()
    {
        counter += Time.deltaTime;
        // Debug.Log(counter);

        if (Input.GetButton("Fire1") && counter > fireRate)
        {
            // Create my laser object
            Instantiate(laser, laserSpawn.position, laser.transform.rotation);
            
           // laser.transform.position = Blaster.transform.position;
            counter = 0.0f;

           // lasers.velocity = new Vector2(bulletspeed,0);


        }

        float vert = Input.GetAxis("Vertical");
        float hori = Input.GetAxis("Horizontal");


     
        Vector2 newVelocity = new Vector2(hori, vert);

        rBody.velocity = newVelocity * speed;

     
        rBody.position = new Vector2(
            Mathf.Clamp(rBody.position.x, minX, maxX),   
            Mathf.Clamp(rBody.position.y, minY, maxY)); 
    }
}
