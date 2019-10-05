using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Source file name:Enemy
 * Author’s name: Sarmad Siddiqi
 * Last Modified by: Sarmad Siddiqi
 * Date last Modified: October 4th
 * Program description: basic Enemy AI Script and handling Scoring and health
 * Revison History: 
 * added basic movement
 * Added Spawn Range
 * Added Scoring and Heatlh
 * 
 * 
 * 
 */
public class Enemy : MonoBehaviour
{
    public float verticalSpeed;
    public float horizontalSpeed;

    public float minY;
    public float maxY;
    public float minX;
    public float maxX;
    public GameController gameController;

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        Vector2 newPosition = new Vector2(horizontalSpeed, verticalSpeed);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

    void Reset()
    {
        horizontalSpeed = Random.Range(minX, maxX);
        verticalSpeed = Random.Range(minY, maxY);

        float randomYPosition = Random.Range(2.1f, -1.5f);
        transform.position = new Vector2(Random.Range(2.0f, 8.0f), randomYPosition);
    }

    void CheckBounds()
    {
        if (transform.position.x <= -4.7)
        {
            Reset();
        }
        else if (transform.position.y <= -1.5)
        {
            Reset();
        }
        else if (transform.position.y >= 2.1)
        {
            Reset();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            gameController.Score += 100;
            Reset();
        }

        if (other.tag == "Player")
        {
            gameController.Lives -= 1;
            Reset();
        }
        

    }
    }
