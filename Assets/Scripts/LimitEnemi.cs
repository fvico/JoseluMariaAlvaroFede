using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitEnemi : MonoBehaviour
{
    private Vector2 currentSpeedEnemi;

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Enemi")
        {
            currentSpeedEnemi = collision.GetComponent<Enemi>().rigidbodyEnemi.velocity;
            Debug.Log(currentSpeedEnemi);
            if (currentSpeedEnemi.x > 0)
            {
                collision.GetComponent<Enemi>().rigidbodyEnemi.velocity = new Vector2(-currentSpeedEnemi.x, 0f);
            }
            else
            {
                collision.GetComponent<Enemi>().rigidbodyEnemi.velocity = new Vector2(+currentSpeedEnemi.x, 0f);
            }


        }
    }
       
}
