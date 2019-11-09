using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemi : MonoBehaviour
{
    public Rigidbody2D rigidbodyEnemi;
    [Range(1, 10)] public float speedEnemi;
    private void Start()
    {
        rigidbodyEnemi = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigidbodyEnemi.velocity = new Vector2(speedEnemi, 0f);
    }
}
