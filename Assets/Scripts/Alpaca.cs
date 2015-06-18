using UnityEngine;
using System.Collections;

public class Alpaca : MonoBehaviour {
	public Vector2 velocity = new Vector2(-4,0);
	public float range = 4;
	
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-6f,-2f),0f);
		transform.position = new Vector2(6f, Random.Range(-4f,4f));
		transform.Rotate (Vector3.forward * Random.Range(0,360));
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -16) {
			Destroy(gameObject);
		}
	}
}
