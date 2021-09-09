using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
    public Animator animator;
    private GameObject fp;

    public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

    private void Start()
    {
        fp = GameObject.Find("FirePoint");

    }
    // Update is called once per frame
    void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
            animator.SetBool("IsJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
            Vector3 temp = new Vector3(fp.transform.position.x, fp.transform.position.y - 0.8f, fp.transform.position.z);
            fp.transform.position = temp;

        } else if (Input.GetButtonUp("Crouch"))
		{
            
            crouch = false;
            Vector3 temp = new Vector3(fp.transform.position.x, fp.transform.position.y + 0.8f, fp.transform.position.z);
            fp.transform.position = temp;
        }
        if(gameObject.transform.position.y <= -20)
        {
            Score.currScore = 0;
            Score.loseLife();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        
    }
    public void OnCrouching(bool isCrouching)
    {


        
        animator.SetBool("IsCrouching", isCrouching);


    }
}
