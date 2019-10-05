using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Source file name:bullet
 * Author’s name: Sarmad Siddiqi
 * Last Modified by: Sarmad Siddiqi
 * Date last Modified: October 4th
 * Program description: Bullet movement speed
 * Revison History: 
 * Added Movement
 * 
 * 
 * 
 */
public class bullet : MonoBehaviour
{
    public float speed = 8.0f;
    private Rigidbody2D rBody;
    

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = Vector2.right * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
