using UnityEngine;
using System.Collections;

public class TitleMenuControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void EnterGameMenu(){
		Application.LoadLevel ("menu_game");
	}

	public void EnterHighScore(){
	}
}
