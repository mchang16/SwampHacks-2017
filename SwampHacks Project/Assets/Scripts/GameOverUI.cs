using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour {

	// Use this for initialization

	public void QuitGame (){
		Application.Quit();
	}

	public void PlayAgain(){
	
		//Loads the Game Over screen, and destroy the screen when you press the Play Again button
		Application.LoadLevel("First 2");
		Destroy (gameObject);
	
	}
	 
	public void LoadLevel2(){

		//Loads the 2nd Level
		Application.LoadLevel("Level 2");
		Destroy (gameObject);

	}

	public void LoadLevel3(){

		//Loads the 3rd Level
		Application.LoadLevel("Level 3");
		Destroy (gameObject);

	}


}
