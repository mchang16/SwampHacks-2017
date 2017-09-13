using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ThirdEnemy : MonoBehaviour {

	public float velocity;

	public Rigidbody2D myRigidbody;

	public bool seeIfMoving;

	public float timeBetweenMove;

	public float timeToMoveCounter;

	public float timeBetweenMoveCounter;

	public float timeToMove;

	public Vector3 Direction;

	public ThirdUI UI;

	public GameObject Target { get; set; }

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();

		timeBetweenMoveCounter = timeBetweenMove;
		timeBetweenMoveCounter = timeBetweenMove;

		//Gets the UIManager
		UI = GameObject.FindWithTag ("UI").GetComponent<ThirdUI>(); //UIMangaer script

	}

	// Update is called once per frame
	void FixedUpdate () {


		if (seeIfMoving) {
			timeToMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = Direction;

			if (timeToMoveCounter < 0f) {                   //when moving, finally hits zero, it will stop
				seeIfMoving = false;
				timeBetweenMoveCounter = timeBetweenMove;

			}
		}
		//Makes the enemy keep going left
		else{
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = Vector2.zero;

			if(timeBetweenMoveCounter < 0f){ //when not moving, finally hits zero, it will then move 
				seeIfMoving = true;
				timeToMoveCounter = timeToMove;

				Direction = new Vector3 (1f, 0f, 0f);


			}
		}
	}

	//If hit by bullet, increment score and destroy the enemy itself
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "Bullet3"){
			UI.IncrementScore3 ();
			Destroy (gameObject);



		}













	}
}
