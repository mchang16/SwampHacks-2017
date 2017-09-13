using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	//If Player collides with enemy, show Game Over screen
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "PenguinTag"){
			Application.LoadLevel ("GameOver");

			Debug.Log("WHYYYY");
		}
	}



}