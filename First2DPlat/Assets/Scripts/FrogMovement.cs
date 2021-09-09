using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D frog;
    public Transform frogT;

    public float jumpForce = 700f;
    bool jump = false;
    private float time = 3f;

    private void Start()
    {
    }
    void Update()
    {
        time -= Time.deltaTime;
        if(time<=0)
        {
            jump = true;
            animator.SetBool("isJumping", true);
            time = 3f;

        }
    }
    private void FixedUpdate()
    {

        if (jump)
        {
            frog.AddForce(new Vector2(0f, jumpForce));
            jump = false;

        }
    }
    void StopJump()
    {
        animator.SetBool("isJumping", false);


    }
    
}
