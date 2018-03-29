using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

	public AudioSource flameSounds;

	void Start(){

		flameSounds = GetComponent<AudioSource> ();
		flameSounds.Stop ();

	}

		void OnTriggerEnter(Collider other){

			if(other.gameObject.CompareTag("player")){
				flameSounds.Play();
			}

	}

	void OnTriggerExit(Collider other){
	
		if (other.gameObject.CompareTag ("player")) {
			flameSounds.Stop ();
		}
	
	
	}

}
