using UnityEngine;
using System.Collections;

public class lightning : MonoBehaviour {

	public GameObject light;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnPreCull () {
		light.SetActive (false);
	}

	void OnPostRender(){
		light.SetActive (true);
	}
	void OnPreRender(){
		light.SetActive (false);
	}
}
