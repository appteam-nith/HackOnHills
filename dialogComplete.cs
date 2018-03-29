using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogComplete : MonoBehaviour {

	public GameObject soundSource;
	AudioSource audioSource;
	public Text subtitles;
	public AudioClip audioClip;



	void Start () {


		audioSource = soundSource.GetComponent<AudioSource> ();

	}
	
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("player")) {
		
			subtitles.text = "Sample 3 of 3 collected";

			if (!audioSource.isPlaying) {
			
				audioSource.clip = audioClip;
				audioSource.Play ();
			}

		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ("player")) {
		
			StartCoroutine (finishedCollecting ());
		
		}

	}

	IEnumerator finishedCollecting(){
		yield return new WaitForSeconds (2);
		subtitles.text = "Objective Completed.";
		yield return new WaitForSeconds (4);
		subtitles.text = "";
	
	
	}

}
