using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GenerateBirdObstacle : MonoBehaviour {
	public GameObject rocks;
	public int score;
	public bool isDead = false;
	Text scoreDisplay;

	// Use this for initialization
	void Start () {
		score = 0;
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
	}
	
	void CreateObstacle () {
		Instantiate (rocks);
		Invoke("AddScore", 3f);
	}

	void AddScore(){
		if (!isDead)
			score++;
	}

	// Update is called once per frame
	void Update(){
		GameObject scoreText = GameObject.Find ("ScoreText");
		scoreDisplay = scoreText.GetComponent<Text>();
		scoreDisplay.text = score.ToString ();
	}
}
