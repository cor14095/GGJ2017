using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class Movie : MonoBehaviour {

	public MovieTexture movie;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		audio = GetComponent<AudioSource> ();
		audio.clip = movie.audioClip;
		movie.Play ();
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
