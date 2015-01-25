using UnityEngine;
using System.Collections;

public class ClearData : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DeleteSavedData(){
		GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().ClearAllData ();
	}
}
