using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float direction;  // 1 = right, -1 = left
	public GameObject Monster;
	// Use this for initialization

	void Start () {
		
	}
	
	void FixedUpdate () {
		//Sets up the direction of the bullet, but references in the Firing script
		//"direction" changes based on the parameters set in Firing script
		transform.Translate (new Vector2 (direction * 0.5f, 0f));
	}

	//Destroys bullet when it comes in contact to enemy
	void OnCollisionEnter2D (Collision2D other){
			if(other.gameObject.tag == "PenguinTag"){
				Destroy(gameObject);

	}
}
}