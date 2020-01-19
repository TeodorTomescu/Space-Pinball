using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	//declaration of variables
	public Text scoreText;
	public Text highScoreText;
	public static float scoreCount;
	public float highScoreCount;
	public float pointsPerSec;
	public bool isDead = false;

	// Initialize points per second to 1
	void Start () {
		pointsPerSec = 1.0f;
	}
	
	// void update runs every frame and updates the score and high score text displayed in the GUI to the scoreCount and highScoreCount respectively
	void Update () {

		if (!isDead)
			scoreCount += pointsPerSec * Time.deltaTime;

		if (scoreCount > highScoreCount) 
			highScoreCount = scoreCount;

		scoreText.text = "Score: " + Mathf.Round(scoreCount);
		highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
	}
}
