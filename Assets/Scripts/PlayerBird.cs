using UnityEngine;
using System.Collections;

public class PlayerBird : MonoBehaviour {
	public Vector2 jumpForce = new Vector2(0,300);
	public Sprite BirdUp;
	public Sprite BirdDown;

	// Use this for initialization
	void Start () {
	
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

	void Die(){
		Application.LoadLevel("title");
	}
}
