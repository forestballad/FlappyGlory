using UnityEngine;
using System.Collections;

public class EnterLevel : MonoBehaviour {
	public string LevelName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartLevel(){
		Application.LoadLevel ("play_original");
	}
}
