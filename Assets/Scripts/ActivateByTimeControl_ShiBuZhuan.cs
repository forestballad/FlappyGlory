using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ActivateByTimeControl_ShiBuZhuan : MonoBehaviour {
	public Sprite sleepBird;
	public bool isActive;

	// Use this for initialization
	void Start () {
		if (System.DateTime.Now.Hour < 7 || System.DateTime.Now.Hour > 23) {
			isActive = false;
		} 
		else {
			isActive = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setActiveByTime(){
		if (!isActive) {
			gameObject.GetComponent<Image> ().sprite = sleepBird;
		}
	}

	public bool checkActive(){
		return isActive;
	}
}
