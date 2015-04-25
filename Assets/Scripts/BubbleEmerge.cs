using UnityEngine;
using System.Collections;

public class BubbleEmerge : MonoBehaviour {
	public float emergeAfter;

	// Use this for initialization
	void Start () {
		Invoke ("emerge", emergeAfter);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void emerge(){
		GetComponent<SpriteRenderer> ().enabled = true;
	}
}
