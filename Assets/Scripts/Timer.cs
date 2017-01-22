using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	float x;
	float y;
	float t;
	float w;
	float timeLeft;

	Vector2 position = new Vector2(20,40);
	Vector2 size = new Vector2(60,20);
	public Texture2D progressBarEmpty;
	public Texture2D progressBarFull;
	float barDisplay = 0;

	// Use this for initialization
	void OnGUI () {
		timeLeft = 300f;
		x = 10;
		y = 200;
		t = 200;
		w = 20;
		/*GUI.BeginGroup (new Rect (position.x, position.y, size.x, size.y));
			GUI.Box(Rect(0,0,size.x,size.y),progressBarEmpty);

			GUI.BeginGroup (new Rect (0, 0, size.x * barDisplay, size.y));
				GUI.Box (Rect (0,0, size.x, size.y),progressBarFull);
			GUI.EndGroup ();

		GUI.EndGroup ();
        */
		GUI.TextField (new Rect (x,y,t,w),"Timer");
		GUI.TextField (new Rect (x,y+20,t,w),Mathf.Floor((timeLeft)/60).ToString("00")+":"+(Mathf.Ceil(timeLeft)%60).ToString("00"));
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft = timeLeft - Time.deltaTime;
		//barDisplay = Time.time * 0.05;
	}
}
