using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float movVelocity = 6f;
	public float rotVelocity = 3f;
	float verticalRotation = 0; 
	public float upDownMax = 60.0f;

	public GameObject cam;

	private PlayMode idle;



	void Start()
	{
       // Cursor.lockState = CursorLockMode.Locked;

	}

	void Update() 
	{
		//rotation

		float rotLeftRight = Input.GetAxis ("HorizontalRotation")*rotVelocity;

		transform.Rotate (0, rotLeftRight, 0);
		//up/down



		//movement
		if (Input.GetAxis ("Run")==1) {

			movVelocity = 12f;
		
		} else {
		
			movVelocity = 6f;
		}
		float forward = Input.GetAxis("Vertical") * movVelocity;
		float side = Input.GetAxis("Horizontal")*movVelocity;

		Vector3 speed = new Vector3(side,0,forward);
		speed = transform.rotation * speed;

		CharacterController cc = GetComponent<CharacterController>();
		cc.SimpleMove (speed);

 		}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name.Equals("PickUp")){
			print ("Do something");
		}
	}


			
}