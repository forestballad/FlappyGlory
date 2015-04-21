using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	public Sprite bulletSprite1;
	public Sprite bulletSprite2;
	public Sprite bulletSprite3;
	public float facing;
	public float speed;

	// Use this for initialization
	void Start () {
		int bulletType = (int)Random.Range (0, 3);
		if (bulletType == 0) {
			GetComponent<SpriteRenderer> ().sprite = bulletSprite1;
		} else if (bulletType == 1) {
			GetComponent<SpriteRenderer> ().sprite = bulletSprite2;
		} else {
			GetComponent<SpriteRenderer> ().sprite = bulletSprite3;
		}
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
