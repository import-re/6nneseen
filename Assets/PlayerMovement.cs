using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public float runSpeed = 40f;
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	//public bool hasHorizontalMove = false;
	public Animator anim;
	

	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;


		if (Input.GetButtonDown("Jump") | Input.GetKeyDown(KeyCode.W))
		{
			jump = true;
			anim.SetBool("isJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

		anim.SetFloat("HorizontalInput", Mathf.Abs(Input.GetAxis("Horizontal")));

		foreach (Transform iChild in transform)
		{
			string tag = iChild.gameObject.tag;
			Debug.Log(tag);
			if (tag == "Weapon")
			{
				runSpeed = 20f;
			}
			else
			{
				runSpeed = 40f;
			}

     	}

	}


	void FixedUpdate ()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}


	public void onLanding()
	{
		anim.SetBool("isJumping", false);
	}
}