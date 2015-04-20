using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyShooter : MonoBehaviour {
	public int health;
	public Slider healthBarSlider;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		InvokeRepeating("LaunchProjectile", 2f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 0) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "PlayerBullet") {
			Destroy (other.gameObject);
			health --;
			healthBarSlider.value -= 0.002f;
		}
	}

	void LaunchProjectile() {
		for (int i = 0;i < 360;i += 15){
			GameObject newBullet = Instantiate(bullet);
			newBullet.GetComponent<EnemyBullet01>().facing = i;
			newBullet.transform.position = transform.position;
		}
	}
}
