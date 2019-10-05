using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Source file name:LandController
 * Author’s name: Sarmad Siddiqi
 * Last Modified by: Sarmad Siddiqi
 * Date last Modified: October 4th
 * Program description: "Scrolling" Background
 * Revison History: 
 * Added Movement
 * Added loop
 * 
 * 
 * 
 */
public class LandController : MonoBehaviour
{

    public float horizontalSpeed = 0.1f;
    public float resetPosition = 2.75f;
    public float resetPoint = -2.75f;
    // Start is called before the first frame update
    void Start()
    {
        //Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();

    }
   
    void Move()
    {
        Vector2 scrolling = new Vector2(horizontalSpeed, 0.0f);
        Vector2 currentPosition = transform.position;

        currentPosition -= scrolling;
        transform.position = currentPosition;
    }

    void CheckBounds()
    {
        if (transform.position.x <= resetPoint)
        {
            Reset();
        }
    }

    void Reset()
    {
        transform.position = new Vector2(resetPosition, 0.0f);
    }

    
    
}
