using UnityEngine;
using System.Collections;

public class EnemyBullet01 : MonoBehaviour {
	public Sprite bulletSprite;
	public float facing;
	public float speed;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = bulletSprite;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y > 5 || transform.position.y < -5 || transform.position.x > 1.8 || transform.position.x < -6.6) {
			Destroy(gameObject);	
		}
	}

	void FixedUpdate(){
		transform.rotation = Quaternion.AngleAxis(facing, new Vector3 (0, 0, 1));
		transform.position = new Vector2 (transform.position.x + Mathf.Cos(facing*Mathf.Deg2Rad)*speed, transform.position.y + Mathf.Sin (facing*Mathf.Deg2Rad)*speed);
	}
}
