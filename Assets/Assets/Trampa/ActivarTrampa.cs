using UnityEngine;
using System.Collections;

public class ActivarTrampa : MonoBehaviour {

    Collider colision;
    Animator animador;

	// Use this for initialization
	void Awake () {
        animador = GetComponent<Animator>();
	}

    void OnTriggerEnter(Collider collision) {
        if (collision.tag == "Player"){
            animador.SetBool("Trampa", true);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
