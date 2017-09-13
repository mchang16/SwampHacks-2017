using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

	GameObject currentPosition;

	float speed;
	// Use this for initialization
	void Start () {
		speed = 20f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		Vector2 currentPosition = transform.position;
		currentPosition = new Vector2 (currentPosition.x - speed * Time.deltaTime, currentPosition.y);
		transform.position = currentPosition;

		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0f,0f));
	
		//Destroys the enemy when it gets to the left side of the screen
		if(transform.position.x < min.x){
		Destroy (gameObject);
	}
	}
}