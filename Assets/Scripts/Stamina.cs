using UnityEngine;
using System.Collections;

public class Stamina : MonoBehaviour {

	Vector2 position = new Vector2(20,300);
	Vector2 size = new Vector2(200,50);
	public GUIStyle progressBarEmpty;
	public GUIStyle progressBarFull;
	public Texture2D emptyTex;
	public Texture2D fullTex;
	float barDisplay = 1f;

	// Use this for initialization
	void OnGUI () {


		GUI.BeginGroup (new Rect (position.x, position.y, size.x * barDisplay, size.y));
		GUI.Box (new Rect (0,0, size.x, size.y),fullTex,progressBarFull);
		GUI.EndGroup ();

		GUI.BeginGroup (new Rect (position.x, position.y, size.x, size.y));
		GUI.Box(new Rect(0,0,size.x,size.y),emptyTex,progressBarEmpty);
		GUI.EndGroup ();

	}

	// Update is called once per frame
	void Update () {
		barDisplay = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement>().stamina;
	}
}
