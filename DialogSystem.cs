using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class DialogSystem : MonoBehaviour {

	public AudioClip dialog1;
	public AudioClip dialog2;
	public AudioClip initialStatic;
	public AudioClip finalStatic;
	public GameObject player;
	public Text subtitles;



void Start () {

		StartCoroutine (dialogs());
		player.GetComponent<Blur> ().enabled = false;
		player.GetComponent<Vortex> ().enabled = false;
		player.GetComponent<NoiseAndGrain> ().enabled = false;


	}

	IEnumerator dialogs(){
		GetComponent<AudioSource> ().clip = initialStatic;
		GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GetComponent<AudioSource> ().clip.length);
		GetComponent<AudioSource> ().clip = dialog1;
		GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GetComponent<AudioSource> ().clip.length);
		GetComponent<AudioSource> ().clip = dialog2;
		GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GetComponent<AudioSource> ().clip.length);
		GetComponent<AudioSource> ().Stop ();
	


	}


	
	
	}








