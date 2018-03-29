using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using UnityEngine.UI;

public class dialogCollection : MonoBehaviour {


	public GameObject soundSource,sun, explosionMaster, player,explosionSource;
	Collider finalTrig;
	AudioSource audioSource,explosionSound;
	public AudioClip audioClip1, audioClip2, audioClip3, audioClip4, audioClip5, audioClip6, audioClip7, audioClip8, audio9;
	public Text subtitles;
	Light sunlight;
	static int sampleCount;
	public GameObject ship1,ship2;
	Rigidbody rig_ship1,rig_ship2;
	bool collide1,collide2,collide3;
	Vector3 explosionDirection = new Vector3(400,10,100);
	public float ExplosionForce;

	void Start () {
		audioSource = soundSource.GetComponent<AudioSource> ();
		sunlight = sun.GetComponent<Light> ();
		sampleCount = 0;
		explosionMaster.SetActive (false);
		explosionSound = explosionSource.GetComponent<AudioSource> ();
		rig_ship1 = ship1.GetComponent<Rigidbody> ();
		rig_ship2 = ship2.GetComponent<Rigidbody> ();
		collide1 = collide2 = collide3 = false;


		
	}


	IEnumerator SampleCountHandler(){
		if (sampleCount == 1) {

			yield return new WaitForSeconds (2);
			subtitles.text = "Press 'R' to turn on/off your flashlight";
			yield return new WaitForSeconds (3);
			subtitles.text = "";

		} 
		else if (sampleCount == 2) {

			yield return new WaitForSeconds (2);
			subtitles.text = "";
		} 
		else if (sampleCount == 3) {

			yield return new WaitForSeconds (2);
			subtitles.text = "Objective Completed.";
			yield return new WaitForSeconds (4);
			subtitles.text = "";
			yield return new WaitForSeconds (2);
			explosionSound.clip = audio9;
			explosionSound.Play ();
			explosionSound.loop = true;
			audioSource.clip = audioClip4;
			explosionMaster.SetActive (true);
			player.GetComponent<NoiseAndGrain>().enabled = true;
			player.GetComponent<Vortex> ().enabled = false;
			player.GetComponent<Blur> ().enabled = true;
			rig_ship1.AddForce (explosionDirection * ExplosionForce);
			rig_ship2.AddForce (explosionDirection * ExplosionForce);
			yield return new WaitForSeconds (1);
			audioSource.Play ();
			subtitles.fontSize = 28;
			subtitles.text = "No! what is happening ? I can not see";

			yield return new WaitForSeconds (audioSource.clip.length+2);
			player.GetComponent<Vortex>().enabled= false;
			player.GetComponent<NoiseAndGrain> ().enabled = false;
			audioSource.clip = audioClip5;
			audioSource.Play ();
			subtitles.text = "No! Hudson, Sophia, Mark, my crewmates, they are all gone....";
			yield return new WaitForSeconds (audioSource.clip.length+5);
			audioSource.clip = audioClip6;
			audioSource.Play ();
			subtitles.text = "Can anyone hear me, answer me goddamnit !";
			yield return new WaitForSeconds (audioSource.clip.length + 3);
			audioSource.clip = audioClip7;
			audioSource.Play ();
			subtitles.fontSize = 24;
			subtitles.text = "This is, this is Captain Marshall speaking from base camp, our ship has exploded to pieces.";
			yield return new WaitForSeconds (audioSource.clip.length + 2);
			audioSource.clip = audioClip8;
			audioSource.Play ();
			subtitles.text = "I.. I think I am going crazy now..I am seeing visions of my past.";
			yield return new WaitForSeconds (audioSource.clip.length + 3);
			Application.LoadLevel (1);


		}





	}

	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("player") && sampleCount == 0 && collide1 == false) {
		
			gameObject.GetComponentInChildren<Renderer> ().enabled = false;	
			subtitles.text = "Sample 1 of 3 collected ";
			sunlight.enabled = false;
			collide1 = true;


			if (!audioSource.isPlaying) {
				audioSource.clip = audioClip1;
				audioSource.Play ();

			}

			
			sampleCount = 1;
			StartCoroutine (SampleCountHandler ());
			
		} else if (other.gameObject.CompareTag ("player") && sampleCount == 1 && collide2 == false) {
		
			gameObject.GetComponentInChildren<Renderer> ().enabled = false;
			subtitles.text = "Sample 2 of 3 Collected";
			collide2 = true;

			if (!audioSource.isPlaying) {
				audioSource.clip = audioClip2;
				audioSource.Play ();
			}
		
			sampleCount = 2;
			StartCoroutine (SampleCountHandler ());
		} 
		else if (other.gameObject.CompareTag ("player") && sampleCount == 2 && collide3 == false) {
			gameObject.GetComponentInChildren<Renderer> ().enabled = false;
			subtitles.text = "Sample 3 of 3 collected";
			collide3 = true;

			if (!audioSource.isPlaying) {
				audioSource.clip = audioClip3;
				audioSource.Play ();
			}
			sampleCount = 3;
			StartCoroutine (SampleCountHandler ());
		}
		
}






	}


	

