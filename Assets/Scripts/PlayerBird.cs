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
		GetComponent<SpriteRenderer>().sprite = BirdUp;
		if (CurrentBird == "YeYuShengFan")
			Invoke ("returnToTitle_SP02", 50f);
		if (CurrentBird == "SuoKeSaEr") {
			GameObject.Find("Scripts").GetComponent<GenerateBirdObstacle>().currentBird ="SuoKeSaEr";
		}
		hitCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
		if (GetComponent<Rigidbody2D>().velocity.y >= 0) {
			GetComponent<SpriteRenderer>().sprite = BirdUp;
		}
		else{
			GetComponent<SpriteRenderer>().sprite = BirdDown;
		}
		transform.localPosition = new Vector3 (-3.49f,transform.position.y,0);
	}

	void OnCollisionEnter2D(Collision2D other){
		Die();
	}

	void ScoreCheck(){
		// stop score recording & set highest score... game may continue due to different level
		GameObject ObstacleGenerator = GameObject.Find("Scripts");
		ObstacleGenerator.GetComponent<GenerateBirdObstacle>().isDead = true;
		scoreAtDeath = ObstacleGenerator.GetComponent<GenerateBirdObstacle>().score;
		GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().setHighScore(CurrentBird,scoreAtDeath);
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
				MusicPlayer.GetComponent<AudioSource>().Play ();
				isDead = true;
				Invoke ("returnToTitle_SP01", 46f);
			}
		} else if (CurrentBird == "YeYuShengFan") {
			ScoreCheck();
			if (scoreAtDeath > 5){
				GameObject.Find("DataAgentObject").GetComponent<DataAgent>().UnlockCharacter(4);
			}
			returnToTitle ();
		} else if (CurrentBird == "SuoKeSaEr"){
			ScoreCheck();
			if (scoreAtDeath > 5){
				GameObject.Find("DataAgentObject").GetComponent<DataAgent>().UnlockCharacter(5);
			}
			returnToTitle();
		} else if (CurrentBird == "WangBuLiuXing"){
			hitCounter++;
			float sizeCoeffcient = 1.2f;
			transform.localScale = new Vector3( transform.localScale.x * sizeCoeffcient, transform.localScale.y * sizeCoeffcient, 0f);
			BoxCollider2D col = (BoxCollider2D)transform.GetComponent<Collider2D>();
			col.size = new Vector3(transform.localScale.x , transform.localScale.y, 0f);
			if (hitCounter > 5){
				ScoreCheck();
				if (scoreAtDeath > 10) GameObject.Find("DataAgentObject").GetComponent<DataAgent>().UnlockCharacter(6);
				returnToTitle();
			}
		} else if (CurrentBird == "ShiBuZhuan"){
			ScoreCheck();
			if (scoreAtDeath > 5){
				GameObject.Find("DataAgentObject").GetComponent<DataAgent>().UnlockCharacter(12);
			}
			returnToTitle();
		}
	}

	void returnToTitle(){
		Application.LoadLevel ("game");
	}

	void returnToTitle_SP01(){
		GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().UnlockCharacter (3);
		Application.LoadLevel ("game");
	}

	void returnToTitle_SP02(){
		GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().UnlockCharacter (4);
		Application.LoadLevel ("game");
	}

	void returnToTitle_SP03(){

	}
}
