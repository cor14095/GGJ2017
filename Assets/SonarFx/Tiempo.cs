﻿using UnityEngine;
using System.Collections;

public class Tiempo : MonoBehaviour {
    public float tiempo = 0f;
    public Vector3 posicion;
    SonarFx sonar;
    bool cuenta = false;
    float tiempores = 0f;
    public Object luz;
	public Camera camara;

	// Use this for initialization
	void Awake() {
        sonar = GetComponent<SonarFx>();
        sonar.enabled = false;
       
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			GetComponent<SonarFx> ().waveColor = new Color32(0xEF,0xBA,0x3E,0x00);
			cuenta = true;
			tiempores = tiempo;
			sonar.enabled = true;
			Vector3 mousePos = Input.mousePosition;
			mousePos.z += 110;
			Vector3 mousePosWorld = camara.ScreenToWorldPoint (mousePos);
			posicion = new Vector3 (mousePosWorld.x, 0, mousePosWorld.z);
			Instantiate (luz, posicion + new Vector3 (0, 50, 0), Quaternion.identity, this.transform);
			sonar.posicion = posicion;
           
		} else if (Input.GetMouseButton (1)) {
			GetComponent<SonarFx> ().waveColor = new Color32(0x43,0xBE,0xE4,0x00);
			cuenta = true;
			tiempores = tiempo;
			sonar.enabled = true;
			Vector3 mousePos = Input.mousePosition;
			mousePos.z += 110;
			Vector3 mousePosWorld = camara.ScreenToWorldPoint (mousePos);
			posicion = new Vector3 (mousePosWorld.x, 0, mousePosWorld.z);
			Instantiate (luz, posicion + new Vector3 (0, 50, 0), Quaternion.identity, this.transform);
			sonar.posicion = posicion;
		}
        if (cuenta == true){
            if (tiempores > 0){
                tiempores -= Time.deltaTime;
            }else{
                sonar.enabled = false;
                cuenta = false;
            }
        }
        

	}
}
