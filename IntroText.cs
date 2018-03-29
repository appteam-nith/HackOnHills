using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour {


	void Start () {

		StartCoroutine (introSequence ());
	}

	IEnumerator introSequence(){
		yield return new WaitForSeconds (4);

		GetComponent<Text> ().color = Color.yellow;
		GetComponent<Text> ().fontSize = 30;
		GetComponent<Text> ().text = "Presents";
		yield return new WaitForSeconds (4);
		GetComponent<Text> ().color = Color.red;
		GetComponent<Text> ().text = "The Stark Void";
		yield return new WaitForSeconds (5);
		GetComponent<Text> ().fontSize = 20;
		GetComponent<Text> ().text = "Music & Voice Acting";
		yield return new WaitForSeconds (2);
		GetComponent<Text>().text = "By Manikya Verma";
		yield return new WaitForSeconds (2);
		GetComponent<Text> ().text = "Story And Plot Design";
		yield return new WaitForSeconds (2);
		GetComponent<Text> ().text = "By Avnish Dhaulta";
		yield return new WaitForSeconds (2);
		GetComponent<Text> ().text = "Programmed & Developed";
		yield return new WaitForSeconds (2);
		GetComponent<Text> ().text = "By Sarthak Sharma";
		yield return new WaitForSeconds (2);
		GetComponent<Text> ().fontSize = 20;
		GetComponent<Text> ().text = "Andrew Marshall's childhood";
		yield return new WaitForSeconds (3);
		GetComponent<Text> ().text = "";
	


	
	
	
	
	
	}
}
	

		