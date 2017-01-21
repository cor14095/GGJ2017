using UnityEngine;
using System.Collections;

public class OutOfBoundsException : MonoBehaviour {

	// Use this for initialization
	void onCollisionStay(Collision collision){
		if (collision.gameObject.layer.Equals ("Wall")) {
		
			
		}
	}
}
