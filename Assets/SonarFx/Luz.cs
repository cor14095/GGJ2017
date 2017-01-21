using UnityEngine;
using System.Collections;

public class Luz : MonoBehaviour {
    public Quaternion rotacion;
    public float maximo = 0, minimo = 0;
    public float tiempo;
    Light luz;
	// Use this for initialization
	void Awake() {
        transform.rotation = rotacion;
        luz = GetComponent<Light>();
        luz.range = maximo;
	}
	
	// Update is called once per frame
	void Update () {
        if (luz.range > minimo) {
            luz.range -= Time.deltaTime * tiempo;
        }
	}
}
