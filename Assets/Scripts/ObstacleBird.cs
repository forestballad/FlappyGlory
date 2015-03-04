using UnityEngine;
using System.Collections;

public class ObstacleBird : MonoBehaviour {
	public Vector2 velocity = new Vector2(-4,0);
	public float range = 4;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - (range * Random.value-2), transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -16) {
			Destroy(gameObject);
		}
	}
}
