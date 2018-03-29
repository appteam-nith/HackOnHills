using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamethrowerTrigger : MonoBehaviour {

	public GameObject emitter1;
	public GameObject emitter2;



	void Start () {

		emitter1.SetActive (false);
		emitter2.SetActive (false);



	}

	void OnTriggerEnter(Collider someone){
	
		if (someone.gameObject.CompareTag ("player")) {

			emitter1.SetActive (true);
			emitter2.SetActive (true);


		
		}
	}

		void OnTriggerExit(Collider someone){

		if(someone.gameObject.CompareTag("player")){

			emitter1.SetActive (false);
			emitter2.SetActive (false);


		}
	
	
	}

}
