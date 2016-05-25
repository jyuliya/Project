using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	private CharacterController characterController;
	public bool isGrounded;
	public float gravity;
	public float fallSpeed;
	public float moveSpeed;
   // private object CrossPlatformInputManager;



    // Use this for initialization
    void Start () {
		characterController = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		
		Fall();
		Move();
        Jump();
	}


	void Move()
	{
		float xSpeed = Input.GetAxis("Horizontal") * moveSpeed;
		if (xSpeed != 0)
		characterController.Move (new Vector3 (0, 0, xSpeed) * moveSpeed * Time.deltaTime);
	}

	void Fall(){
        if (!isGrounded)
        {
            characterController.Move(new Vector2(0, -8) * Time.deltaTime);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ground(Clone)")
        {
            isGrounded = true;
        }
    }

    void Jump () {
        if (Input.GetButton("Jump"))
        { 
        characterController.Move(new Vector2 (0, 1));
            Debug.Log(1);
        isGrounded = false;
        }
        
    }
}


