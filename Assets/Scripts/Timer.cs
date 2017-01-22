using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float x;
	public float y;
	public float t;
	public float w;
	public float timeLeft;
	// Use this for initialization
	void OnGUI () {
		x = 10;
		y = 200;
		t = 200;
		w = 20;
		GUI.TextField (new Rect (x,y,t,w),"Timer");
		GUI.TextField (new Rect (x,y+20,t,w),Mathf.Floor((timeLeft)/60).ToString("00")+":"+(Mathf.Ceil(timeLeft)%60).ToString("00"));
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft = timeLeft - Time.deltaTime;
	}
}
