using UnityEngine;
using System.Collections;

public class SelfBulletControl : MonoBehaviour {
	private float bulletSpeed = 0f;
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		bulletSpeed = player.GetComponent<PlayerShooter> ().BulletSpeed;
		gameObject.transform.position = new Vector2 (player.transform.position.x, player.transform.position.y+0.8f);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > 5) {
			Destroy(gameObject);	
		}
	}

	void FixedUpdate(){
		gameObject.transform.position = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y + bulletSpeed);
	}
}
