using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbodyPlayer;
    [Range(1,100)] public int aceleration;
    [Range(1, 200)] public int forceJump;
    public LayerMask groundMask;
    public Animator animator;
    private bool isGrounded;
    private bool haveAlcohol;
    private bool m_FacingRight = true;
    float moveHorizontal = 0f;
    //variable giro pj
    float move;




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
        
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        if (CheckGroud())
        {
            
            rigidbodyPlayer.velocity = new Vector2(moveHorizontal * aceleration, rigidbodyPlayer.velocity.y);
            animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));  
            //gira la animacion
            if (moveHorizontal > 0 && !m_FacingRight)
            {
                
                Flip();
            }
            
            else if (moveHorizontal < 0 && m_FacingRight)
            {
                // ... flip the player.
                Flip();
            }
        }
        //rigidbodyPlayer.AddForce(new Vector2(moveHorizontal * aceleration, 0f));

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
        //jump = Input.GetAxis("Jump");
        if (CheckGroud())
        {
            jump = Input.GetAxis("Jump");
            rigidbodyPlayer.AddForce(new Vector2(0f, jump * forceJump));
            animator.SetBool("IsJumping", true);
        }
       
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            
            isGrounded = true;
            animator.SetBool("IsJumping", false);
        }
    }
    //public void OnLanding()
    //{
    //    animator.SetBool("IsJumping", false);
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemi" && collision.GetComponent<Enemi>().isActivated)
        {

            collision.gameObject.SetActive(false);
        }
        if(collision.tag == "DeadPoint")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.tag == "Picker")
        {
            
        }
    }
    private void Flip()
    {
        // Cambia la direccion en la que el player esta mirando
        m_FacingRight = !m_FacingRight;

        // Multiplica la x de la escala local del player por -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


}
