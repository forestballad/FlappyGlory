using UnityEngine;
using System.Collections;

public class PlayerBreaker : MonoBehaviour {
	public float speed;
	public bool inPosition;

	int hitTime;

	// Use this for initialization
	void Start () {
		inPosition = false;
		hitTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			gameObject.transform.position = new Vector2(gameObject.transform.position.x + speed,gameObject.transform.position.y);
		}
		if (Input.GetKeyDown (KeyCode.Space) && inPosition) {
			hitTime ++;
		}
		if (hitTime == 20) {
			GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().UnlockCharacter (13);
			Application.LoadLevel ("game");
		} 
	}
}
