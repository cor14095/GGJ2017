using UnityEngine;
using System.Collections;

public class ActivarTrampa : MonoBehaviour {
    public float tiempo = 0f;
    Collider colision;
    Animator animador;
    bool trampa = false;
    float tiempores;

	// Use this for initialization
	void Awake () {
        animador = GetComponent<Animator>();
	}

    void OnTriggerEnter(Collider collision) {
        if (collision.tag == "Player"){
            animador.SetBool("Trampa", true);
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
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
                
            }
        }
	}
}
