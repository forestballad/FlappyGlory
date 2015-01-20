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
		Vector3 temp = new Vector3(0,0,-5f);
		gameObject.transform.position += temp;
	}
}
