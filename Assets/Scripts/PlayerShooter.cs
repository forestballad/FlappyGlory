using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour {
	public float NormalSpeed = 0f;
	public float ShiftSpeed = 0f;
	public float BulletSpeed = 0f;
	public float BoundingBoxUp = 0f;
	public float BoundingBoxDown = 0f;
	public float BoundingBoxLeft = 0f;
	public float BoundingBoxRight = 0f;
	public Sprite NormalSprite;
	public Sprite ShiftSprite;
	public GameObject Bullet;
	public int bulletInterval;
	private int frameCount;
	bool shiftStance = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift))
			shiftStance = true;
		else 
			shiftStance = false;
		if (shiftStance) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = ShiftSprite;
		} else
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = NormalSprite;
		}
	}

	void FixedUpdate(){
		float movex = Input.GetAxis ("Horizontal");
		float movey = Input.GetAxis ("Vertical");
		float targetX;
		float targetY;
		if (shiftStance) {
			targetX= gameObject.transform.position.x + movex * ShiftSpeed;
			targetY = gameObject.transform.position.y + movey * ShiftSpeed;
		}
		else{
			targetX= gameObject.transform.position.x + movex * NormalSpeed;
			targetY = gameObject.transform.position.y + movey * NormalSpeed;
		}
		if (targetX > BoundingBoxRight)	targetX = BoundingBoxRight;
		if (targetX < BoundingBoxLeft)	targetX = BoundingBoxLeft;
		if (targetY > BoundingBoxUp)	targetY = BoundingBoxUp;
		if (targetY < BoundingBoxDown)	targetY = BoundingBoxDown;
		gameObject.transform.position = new Vector2 (targetX, targetY);

		frameCount ++;
		if (frameCount % bulletInterval == 0 && Input.GetKey (KeyCode.Z)) {
			Instantiate (Bullet);
		}
	}
}
