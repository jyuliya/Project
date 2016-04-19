using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
    private CharacterController characterController;
    public bool isGrounded;
    public float gravity;
    public float jumpSpeed;
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
        Jump();
		Move ();
	}



    void Move()
    {
		//float xSpeed = Input.GetAxis("Horizontal") * moveSpeed;
		float ySpeed = 0;
		float xSpeed = Input.GetAxis("Horizontal") * moveSpeed;
		if (xSpeed != 0)
			characterController.Move (new Vector3 (0, xSpeed, 0) * moveSpeed * Time.deltaTime);
		//if (ySpeed != 0)
			//characterController.Move (new Vector3 (0, 0, ySpeed) * moveSpeed * Time.deltaTime);*/
    }

	void Jump () {
		if (Input.GetButtonDown ("Jump") && isGrounded) {
			fallSpeed = -jumpSpeed;
		}
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
}
