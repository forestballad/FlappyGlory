using UnityEngine;
using System.Collections;

public class SaveDataToPlayerPref : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void SaveData(){
		GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().SaveDataToPlayerPref ();
	}
}
