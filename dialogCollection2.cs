using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using UnityEngine.UI;

public class dialogCollection2 : MonoBehaviour {

	public GameObject soundSource;
	AudioSource audioSource;
	public AudioClip audioClip;
	public Text	subtitles;
	public Light sunlight;
	public GameObject sun;
	public int sampleCount;


	void Start () {
		audioSource = soundSource.GetComponent<AudioSource> ();
		sampleCount = 0;
		sunlight = sun.GetComponent<Light> ();
	}
	
	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("player")) {
		
			subtitles.text = "Sample 2 of 3 collected.";
			if (!audioSource.isPlaying) {
			
				audioSource.clip = audioClip;
				audioSource.Play ();

				StartCoroutine (secondCollection ());
			
			}

		
		}

	}
	IEnumerator secondCollection(){
		yield return new WaitForSeconds (2);
		subtitles.text = "";
	
	}


	
	}

