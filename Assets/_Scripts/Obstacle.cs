using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float verticalSpeed;
    public float horizontalSpeed;

    public float minY;
    public float maxY;
    public float minX;
    public float maxX;
    public GameController gameController;
    public AudioSource Hit;

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
            verticalSpeed = -verticalSpeed;
        }
        else if (transform.position.y >= 2.1)
        {
            verticalSpeed = -verticalSpeed;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {      

        if (other.tag == "Player")
        {
            Hit.Play();
            gameController.Lives -= 1;
        }


    }
}
