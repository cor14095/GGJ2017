using UnityEngine;
using System.Collections;

public class Ganar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
