using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbodyPlayer;
    [Range(1,100)] public int aceleration;
    [Range(1, 100)] public int forceJump;
    public LayerMask groundMask;
    private bool isGrounded;

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
        //rigidbodyPlayer.velocity = new Vector2(moveHorizontal * aceleration, rigidbodyPlayer.velocity.y);
        rigidbodyPlayer.AddForce(new Vector2(moveHorizontal * aceleration, 0f));
    }
    private bool CheckGroud()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1f, groundMask);
        if (hit)
        {
            return isGrounded = true;
        }
        else
        {
            return isGrounded = false;
        }
    }

    public void Jump()
    {
        float jump;
        jump = Input.GetAxisRaw("Jump");
        if (CheckGroud())
        {
            rigidbodyPlayer.AddForce(new Vector2(0f, jump * forceJump));
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemi")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
