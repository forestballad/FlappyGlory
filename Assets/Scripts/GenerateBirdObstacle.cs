using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GenerateBirdObstacle : MonoBehaviour {
	public GameObject rocks;
	public string currentBird = "default";
	public int score;
	public bool isDead = false;
	Text scoreDisplay;

	// Use this for initialization
	void Start () {
		score = 0;
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
	}
	
	void CreateObstacle () {
		GameObject newRock = Instantiate (rocks);
		if (currentBird == "default") {
			Invoke ("AddScore", 3f);
		}
		else if (currentBird == "SuoKeSaEr") {
			float speed = 1.5f;
			newRock.GetComponent<ObstacleBird>().velocity = new Vector2(-4/speed,0);
			Invoke("AddScore",3/speed);
		}
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
