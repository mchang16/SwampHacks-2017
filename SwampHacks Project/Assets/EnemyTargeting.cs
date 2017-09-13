using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargeting : MonoBehaviour {
	[SerializeField]
	private Enemy enemy;

	void OnTriggerEnter2D(Collider2D other){    //what your're colliding with
		if(other.tag == "Player"){
			enemy.Target = other.gameObject;
		}
}
}