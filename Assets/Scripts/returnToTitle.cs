using UnityEngine;
using System.Collections;

public class returnToTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void returnToTitleMenu(){
		Application.LoadLevel("title");
	}
}
