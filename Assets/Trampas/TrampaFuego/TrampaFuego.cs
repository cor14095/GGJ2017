using UnityEngine;
using System.Collections;

public class TrampaFuego : MonoBehaviour {
    public GameObject fogata;
	// Use this for initialization
	void Start () {
        
	}
	

     void OnTriggerEnter(Collider collision) {
        if (collision.tag == "Player"){
            Instantiate(fogata,transform.position, Quaternion.identity,transform);
        }
     }
	// Update is called once per frame
	void Update () {
	    
	}
}
