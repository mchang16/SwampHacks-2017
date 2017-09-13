using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdFiring : MonoBehaviour {

	public GameObject bulletTemplate;
	public GameObject chocoTemplate;
	public int coolDownTimer = -1;
	public int direction = 1;

	// Use this for initialization
	void Start () {
		Debug.Log ("Starting!");
	}

	void FixedUpdate () {

		//If you press "A", you fire a bullet
		if (Input.GetKey (KeyCode.S) && coolDownTimer <= 0) {
			GameObject bullet = Instantiate (bulletTemplate, transform.position, Quaternion.identity);
			ThirdBullet bulletScript = bullet.GetComponent<ThirdBullet>();

			//Moves the bullet a bit to the right if player faces right
			if (transform.localScale.x >= 0f) {                 
				bullet.transform.Translate (1f, 0f, 0f);
			} 

			//Moves the bullet a bit to the left if player faces left
			else {
				bullet.transform.Translate (-1f, 0f, 0f);

			} 

			//If player is facing right, shoot the bullet to the right
			if (transform.localScale.x > 0f) {
				bulletScript.direction = 1f;
			} 
			//if player facing left, bullet shoots left
			else {
				bulletScript.direction = -1f;
			}
			coolDownTimer = 45;     //restates the value of cool down timer, so larger gap between 60 and negative, so you shoot less
		}

		coolDownTimer -= 1;

		//Shoot donuts if you press K
		if (Input.GetKey (KeyCode.K) && coolDownTimer <= 0) {
			GameObject bullet2 = Instantiate (chocoTemplate, transform.position, Quaternion.identity);
			ThirdBullet bulletScript2 = bullet2.GetComponent<ThirdBullet>();

			if (transform.localScale.x >= 0f) {                 //Translate code
				bullet2.transform.Translate (1f, 0f, 0f);
			} 
			else {
				bullet2.transform.Translate (-1f, 0f, 0f);

			} 


			if (transform.localScale.x > 0f) {
				bulletScript2.direction = 1f;
			} else {
				bulletScript2.direction = -1f;
			}
			coolDownTimer = 60;
		}

		coolDownTimer -= 1;

	}

}


