using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemi : MonoBehaviour
{
    public Rigidbody2D rigidbodyEnemi;
    [Range(1, 10)] public float speedEnemi;
    bool positiveDirection = false;
    Vector2 currentSpeed;
    public bool isActivated;
    [Range(1, 4)] public int numbEnemi;
    private void Start()
    {
        isActivated = true;
        rigidbodyEnemi = GetComponent<Rigidbody2D>();
        
    }
    private void FixedUpdate()
    {
        currentSpeed = rigidbodyEnemi.velocity;
        MoveEnemi();
    }

    void MoveEnemi()
    {
        if (positiveDirection)
        {
            rigidbodyEnemi.velocity = new Vector2(speedEnemi, 0f);
        }
        else
        {
            rigidbodyEnemi.velocity = new Vector2(-speedEnemi, 0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "LimitEnemi")
        {
            if (currentSpeed.x < 0)
            {
                positiveDirection = true;
            }
            else
            {
                positiveDirection = false;
            }
        }
    }
}
