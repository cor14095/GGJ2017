using UnityEngine;
using System.Collections;

public class TrampaFuego : MonoBehaviour {
    public GameObject fogata;
    public float tiempo;
    bool trampa = false;
    float tiempores = 0f;
	// Use this for initialization
	void Start () {
        
	}
	

     void OnTriggerEnter(Collider collision) {
        if (collision.tag == "Player"){
            Instantiate(fogata,transform.position, Quaternion.identity,transform);
            if (!trampa) { tiempores = tiempo; }
            trampa = true;
        }

     }
	// Update is called once per frame
	void Update () {
        if (trampa)
        {
            if (tiempores > 0)
            {
                tiempores -= Time.deltaTime;
            }
            else
            {
                Application.LoadLevel(2);
            }
        }
	}
}
