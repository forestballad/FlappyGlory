using UnityEngine;
using System.Collections;

public class PlayerBird : MonoBehaviour {
	public Vector2 jumpForce = new Vector2(0,300);
	public string CurrentBird;
	public Sprite BirdUp;
	public Sprite BirdDown;
	private bool isDead = false;
	private int scoreAtDeath;
	private int hitCounter;

	// Use this for initialization
	void Start () {
		if (CurrentBird == "YeYuShengFan")
			Invoke ("returnToTitle_SP02", 50f);
		if (CurrentBird == "YeYuShengFan") {
			Invoke ("returnToTitle_SP03", 180f);
			hitCounter = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}
		if (rigidbody2D.velocity.y >= 0) {
			GetComponent<SpriteRenderer>().sprite = BirdUp;
		}
		else{
			GetComponent<SpriteRenderer>().sprite = BirdDown;
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		Die();
	}

	void ScoreCheck(){
		// stop score recording
		GameObject ObstacleGenerator = GameObject.Find("Scripts");
		ObstacleGenerator.GetComponent<GenerateBirdObstacle>().isDead = true;
		scoreAtDeath = ObstacleGenerator.GetComponent<GenerateBirdObstacle>().score;
	}

	void Die(){
		if (CurrentBird == "Original") {
			ScoreCheck();
			if (scoreAtDeath > 5) {
				GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().UnlockCharacter (1);
			}
			returnToTitle ();
		} else if (CurrentBird == "MeiGuang") {
			ScoreCheck();
			if (scoreAtDeath > 5) {
				GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().UnlockCharacter (2);
			}
			returnToTitle ();
		} else if (CurrentBird == "BaoZiRuQin") {
			ScoreCheck();
			GameObject MusicPlayer = GameObject.Find ("MusicObject");
			if (!isDead) {
				MusicPlayer.audio.Play ();
				isDead = true;
				Invoke ("returnToTitle_SP01", 50f);
			}
		} else if (CurrentBird == "YeYuShengFan") {
			ScoreCheck();
			if (scoreAtDeath > 5){
				GameObject.Find("DataAgentObject").GetComponent<DataAgent>().UnlockCharacter(4);
			}
			returnToTitle ();
		} else if (CurrentBird == "SuoKeSaEr"){
			hitCounter++;
			slowObstacleSpawn();
			if (hitCounter >= 10) returnToTitle_SP03();
		}
	}

	void returnToTitle(){
		Application.LoadLevel ("title");
	}

	void returnToTitle_SP01(){
		GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().UnlockCharacter (3);
		Application.LoadLevel ("title");
	}

	void returnToTitle_SP02(){
		GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().UnlockCharacter (4);
		Application.LoadLevel ("title");
	}

	void returnToTitle_SP03(){
		GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().UnlockCharacter (5);
		Application.LoadLevel ("title");
	}
}
