using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightController : MonoBehaviour {


	public GameObject flashLight;
	Light myLight;


	void Start () {
	
		myLight = flashLight.GetComponent<Light> ();

	}
	
void Update () {

		if (Input.GetKeyDown (KeyCode.R)) {
			Debug.Log ("it works");
			myLight.enabled = !myLight.enabled;
		}
		
	}
}
