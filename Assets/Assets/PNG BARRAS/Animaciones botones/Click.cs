using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
    Animator animador;
    public int boton;
    float tiempores = 0f;
    public float tiempo = 0f;
    bool comprobar = false;
    // Use this for initialization
	void Awake () {
        animador = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void OnMouseDown () {
        tiempores = tiempo;
        animador.SetBool("Click", true);
        comprobar = true;
	}

    void OnMouseUp() {
        animador.SetBool("Click", false);
    }
    void Update() {
        if (tiempores > 0)
        {
            tiempores -= Time.deltaTime;
        }
        else
        {
            if (comprobar)
            {
                Botones(boton);
            }
        }        
    }

    void Botones(int valor) {
        if (boton == 0) {
            Application.LoadLevel(1);
        }
    }
}
