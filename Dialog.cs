using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour {

	public GameObject soundSource;
	AudioSource masterSource;
	public AudioClip myClip;


	void Start () {
		masterSource = soundSource.GetComponent<AudioSource> ();

		}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("player")){
			Debug.Log("Collision Occured.");
			if (!masterSource.isPlaying) {
			
				masterSource.clip = myClip;
				masterSource.Play ();
			
			}
		
		
		}
	}
}
