using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbodyPlayer;
    [Range(1,100)] public int aceleration;
    [Range(1, 100)] public int forceJump;

    private void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move();
        Jump();
    }
    public void Move()
    {
        float moveHorizontal;
        moveHorizontal = Input.GetAxis("Horizontal");
        rigidbodyPlayer.velocity = new Vector2(moveHorizontal * aceleration, rigidbodyPlayer.velocity.y);
    }
    public void Jump()
    {
        float jump;
        jump = Input.GetAxisRaw("Jump");
        rigidbodyPlayer.AddForce(new Vector2(0f, jump * forceJump));
    }
}
