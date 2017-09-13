using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public float MaxSpawnRate = 4f;

	public GameObject PenguinTemplate;
	// Use this for initialization
	void Start () {

		Invoke ("SpawnEnemy", MaxSpawnRate);
		InvokeRepeating ("IncreaseSpeed", 0f, 30f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void SpawnEnemy(){

		//bottom of the screen
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));

		//top of the screen
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1,1));

		//Create enemy
		GameObject aEnemy = (GameObject)Instantiate(PenguinTemplate);


		//Random genererated placement for enemy to appear
		aEnemy.transform.position = new Vector2 (max.x, Random.Range(min.y,max.y));
	
		ScheduleNextSpawn ();
	
	
		}

	void ScheduleNextSpawn (){
	
		float SpawninSeconds;

		if (MaxSpawnRate > 1f) {
			SpawninSeconds = Random.Range (1f, MaxSpawnRate);
		
		} else
			SpawninSeconds = 1f;

		Invoke ("SpawnEnemy", SpawninSeconds);
	}

	void IncreaseSpeed(){
	
		if (MaxSpawnRate > 1f)
			MaxSpawnRate--;

		if (MaxSpawnRate == 1f)
			CancelInvoke ("IncreaseSpeed");
	
	
	}

}

