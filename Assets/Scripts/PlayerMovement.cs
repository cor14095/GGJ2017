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
	public float forward;
	public float side;
	public float stamina = 1f;


	void Start()
	{
       // Cursor.lockState = CursorLockMode.Locked;

	}

	void Update() 
	{
		
		//rotation
		forward=0f;
		side = 0f;

		float rotLeftRight = Input.GetAxis ("HorizontalRotation")*rotVelocity;

		transform.Rotate (0, rotLeftRight, 0);
		//up/down

		if (stamina > 1f)
			stamina = 1f;

		//movement
		if (Input.GetAxis ("Run")==1 && stamina> 0f) {
			stamina -= Time.deltaTime * 0.5f;
			movVelocity = 12f;
		
		} else if(stamina<1f) {
			stamina += Time.deltaTime * 0.08f;
			movVelocity = 6f;
		}
		forward = Input.GetAxis("Vertical") * movVelocity;
		side = Input.GetAxis("Horizontal")*movVelocity;

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