using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	float x=10f;
	float y=200f;
	float t=200f;
	float w=20f;
	float timeLeft = 300f;

	Vector2 position = new Vector2(20,40);
	Vector2 size = new Vector2(200,50);
	public GUIStyle progressBarEmpty;
	public GUIStyle progressBarFull;
	public Texture2D emptyTex;
	public Texture2D fullTex;
	float barDisplay = 0.5f;

	// Use this for initialization
	void OnGUI () {


		GUI.BeginGroup (new Rect (position.x, position.y, size.x * barDisplay, size.y));
			GUI.Box (new Rect (0,0, size.x, size.y),fullTex,progressBarFull);
		GUI.EndGroup ();

		GUI.BeginGroup (new Rect (position.x, position.y, size.x, size.y));
				GUI.Box(new Rect(0,0,size.x,size.y),emptyTex,progressBarEmpty);
			GUI.EndGroup ();

        
		GUI.TextField (new Rect (x,y,t,w),"Timer");
		GUI.TextField (new Rect (x,y+20,t,w),Mathf.Floor((timeLeft)/60).ToString("00")+":"+(Mathf.Ceil(timeLeft)%60).ToString("00"));
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft = timeLeft - Time.deltaTime;

		Debug.Log (barDisplay);
		barDisplay = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Tiempo> ().clicks * 0.01f;
	}
}
