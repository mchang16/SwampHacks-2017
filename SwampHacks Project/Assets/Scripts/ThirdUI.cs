using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdUI : MonoBehaviour {

	int score = 0;

	public Text scoreText;  //"Text" tells you what type, like this will only accessing Text Objects.

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	public void IncrementScore3(){
		score++;
		scoreText.text = "Score : " + score;  //.text means display a String

		if(score == 15){
			Application.LoadLevel ("Winning Screen");
		}

		// this will appear, but what you put in the text box is what appears initially, before anything happens


	}
}