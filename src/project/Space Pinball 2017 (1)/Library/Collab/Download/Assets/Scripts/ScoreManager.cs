using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text highScoreText;

	public static float scoreCount;
	public float highScoreCount;

	public float pointsPerSec;

	public bool isDead = false;

	// Use this for initialization
	void Start () {
		pointsPerSec = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (!isDead)
			scoreCount += pointsPerSec * Time.deltaTime;

		if (scoreCount > highScoreCount) 
			highScoreCount = scoreCount;

		scoreText.text = "Score: " + Mathf.Round(scoreCount);
		highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
	}
}
