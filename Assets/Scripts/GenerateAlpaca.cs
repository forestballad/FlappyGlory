using UnityEngine;
using System.Collections;

public class GenerateAlpaca : MonoBehaviour {
	public GameObject Alpaca;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateAlpaca", 0f, 10f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateAlpaca(){
		Instantiate (Alpaca);
	}
}
