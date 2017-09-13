using UnityEngine;

public class ThirdGameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	//If Player collides with enemy, show Game Over screen
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "3"){
			Application.LoadLevel ("GameOver");

			Debug.Log("WHYYYY");
		}
	}



}
