using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    
    bool jump = false;
    
    //bool crouch = false;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            
        }
        //Sería para hacer que vaya más lento o se acache pero no lo necesitamos si queremos luego lo añadiremos
        //if (Input.GetButtonDown("Crouch"))
        //{
        //    crouch = true;
        //}
        //else if (Input.GetButtonUp("Crouch"))
        //{
        //    crouch = false;
        //}
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }
    
        void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false /*crouch*/ , jump);
        jump = false;
    }
}
