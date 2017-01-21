using UnityEngine;
using System.Collections;

public class MapGen : MonoBehaviour {

	public GameObject plane;
	GameObject cubesHolder;
	public GameObject cube;
	Vector3 planeScale;
	Vector3 center;
	float border;
	Vector3 cubeScale;
	float cubeX;

	// Use this for initialization
	void Start () {
		planeScale = plane.transform.localScale; 
		center = plane.transform.position;
		border = planeScale.x * 5;
		cubeScale = cube.transform.localScale;
		cubeX = cubeScale.x * .5f;
		cubesHolder = new GameObject ();
	}
	
	// Update is called once per frame
	void Update () {
		
		float x = Random.Range (-border+cubeX, border-cubeX);	
		float z = Random.Range (-border+cubeX, border-cubeX);
		GameObject cube1 = (GameObject)Instantiate (cube, new Vector3 (x, cubeX, z),Quaternion.identity);
		cube1.transform.parent= cubesHolder.transform;
			
	}
}
