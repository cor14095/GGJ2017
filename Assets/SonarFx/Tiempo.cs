using UnityEngine;
using System.Collections;

public class Tiempo : MonoBehaviour {
    public float tiempo = 0f;
    public Vector3 posicion;
    SonarFx sonar;
    bool cuenta = false;
    float tiempores = 0f;
    public Object luz;


	// Use this for initialization
	void Awake() {
        sonar = GetComponent<SonarFx>();
        sonar.enabled = false;
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            cuenta = true;
            tiempores = tiempo;
            sonar.enabled = true;
            Vector3 mousePos = Input.mousePosition;
            mousePos.z += 50;
            Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);
            posicion = new Vector3(mousePosWorld.x, 0, mousePosWorld.z);
            Instantiate(luz, posicion+ new Vector3(0,50,0), Quaternion.identity, this.transform);
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
