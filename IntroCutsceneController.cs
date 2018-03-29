using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCutsceneController : MonoBehaviour {

	public Camera playerCam;
	public Camera cutsceneCam;
	public GameObject anim;

	void Start () {
		playerCam.enabled = false;
		cutsceneCam.enabled = true;


		StartCoroutine (TheSequence ());

}
	

	IEnumerator TheSequence(){

	
		yield return new WaitForSeconds (50);

			cutsceneCam.enabled = false;
			playerCam.enabled = true;

		

	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.R)) {
		
			anim.GetComponent<Animation> ().Stop ();
			cutsceneCam.enabled = false;
			playerCam.enabled = true;
		}

	}


}


