using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	private CharacterController characterController;
	public bool isGrounded;
	public float gravity;
	public float fallSpeed;
	public float moveSpeed;
    


	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		IsGrounded();
		Fall();
		Move();
        
	}


	void Move()
	{
		float xSpeed = Input.GetAxis("Horizontal") * moveSpeed;
		if (xSpeed != 0)
		characterController.Move (new Vector3 (0, 0, xSpeed) * moveSpeed * Time.deltaTime);
	}

	void Fall(){
		if (!isGrounded) {
			fallSpeed += gravity * Time.deltaTime;
		} else {
			if (fallSpeed > 0)
				fallSpeed = 0;
		}
		characterController.Move (new Vector3(0, -fallSpeed) * Time.deltaTime);
	}

	void IsGrounded ()
	{
		isGrounded = (Physics.Raycast(transform.position, -transform.up, characterController.height/1.8F));
	}
	/*
	void Jump () {
        //float jSpeed = Input.GetAxis("Vertical") * jumpSpeed;

        }*/
}


