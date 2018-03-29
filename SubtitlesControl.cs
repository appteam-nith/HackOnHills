using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitlesControl : MonoBehaviour {


	public GameObject audio;
	AudioSource audioSource;
	Text subs;

	void Start(){

		audioSource = audio.GetComponent<AudioSource> ();
		subs = GetComponent<Text> ();
		subs.enabled = false;
		StartCoroutine (subtitlesRoutine ());
	}

	IEnumerator subtitlesRoutine(){
	
		yield return new WaitForSeconds (7);
		subs.enabled = true;
		yield return new WaitForSeconds (audioSource.clip.length);
		subs.text = "";
		subs.color = Color.red;
		subs.fontSize = 18;
		subs.text = "This is Hudson from control room, let's wrap this up captain, collect the sample from the crater and we"; 
		yield return new WaitForSeconds (6);
		subs.text="are good to go.";
		yield return new WaitForSeconds (1);
		subs.fontSize = 24;
		subs.text = "New Objective : Collect the Samples";
		yield return new WaitForSeconds (5);
		subs.text = "";


	
	}


}