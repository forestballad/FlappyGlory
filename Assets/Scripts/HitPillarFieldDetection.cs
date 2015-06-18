using UnityEngine;
using System.Collections;

public class HitPillarFieldDetection : MonoBehaviour {
	public PlayerBreaker scriptRef;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		}

	void OnTriggerEnter2D(Collider2D other) {
		scriptRef.inPosition = true;
	}
}
