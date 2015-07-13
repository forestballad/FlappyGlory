using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyShooter : MonoBehaviour {
	public int fullHealth;
	public int currentHealth;
	public Slider healthBarSlider;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		InvokeRepeating("LaunchProjectile", 2f, 0.3f);
		currentHealth = fullHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth <= 0) {
			Destroy(gameObject);
			CancelInvoke("LaunchProjectile");
			GameObject.Find("DataAgentObject").GetComponent<DataAgent> ().setHighScore("YiQiangChuanYun",GameObject.Find("Scripts").GetComponent<YiQiangChuanYunGameControl>().score);
			GameObject.Find("DataAgentObject").GetComponent<DataAgent>().UnlockCharacter(10);
			Application.LoadLevel ("game");
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "PlayerBullet") {
			Destroy (other.gameObject);
			currentHealth --;
			healthBarSlider.value -= 1f/fullHealth;
		}
	}

	void LaunchProjectile() {
		int initialPosition = (int)Random.Range(0, 360);
		for (int i = 0;i < 360;i += 20){
			GameObject newBullet = Instantiate(bullet);
			newBullet.GetComponent<EnemyBullet>().facing = i+initialPosition;
			newBullet.transform.position = transform.position;
		}
	}
}
