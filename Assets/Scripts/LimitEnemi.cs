using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitEnemi : MonoBehaviour
{
    public GameObject enemi;
    private Enemi currentSpeedEnemi;
    private void Start()
    {
        currentSpeedEnemi = enemi.GetComponent<Enemi>();
    }

    private void Update()
    {
        if(currentSpeedEnemi.rigidbodyEnemi.velocity.x < 0)
        {
            currentSpeedEnemi.rigidbodyEnemi.velocity = new Vector2(-currentSpeedEnemi.rigidbodyEnemi.velocity.x,0f);
        }
    }
}
