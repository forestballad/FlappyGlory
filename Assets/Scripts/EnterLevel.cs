using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnterLevel : MonoBehaviour {
	public int CharacterNumber;
	public string LevelName;
	public Sprite LockedSprite;
	public Sprite ActiveSprite;
	public bool CharacterLock = false;

	// Use this for initialization
	void Start(){
		CharacterLock = GameObject.Find ("DataAgentObject").GetComponent<DataAgent>().CharacterLockStatus (CharacterNumber);
		if (!CharacterLock) {
			gameObject.GetComponent<Image>().sprite = LockedSprite;
		}
		else {
			gameObject.GetComponent<Image>().sprite = ActiveSprite;
		}
	}

	void Awake () {

	}
	
	// Update is called once per frame
	void Update () {
		CharacterLock = GameObject.Find ("DataAgentObject").GetComponent<DataAgent>().CharacterLockStatus (CharacterNumber);
		if (!CharacterLock) {
			gameObject.GetComponent<Image>().sprite = LockedSprite;
		}
		else {
			gameObject.GetComponent<Image>().sprite = ActiveSprite;
		}
	}

	public void StartLevel(){

		if (CharacterLock) {
			Application.LoadLevel(LevelName);
		}
	}
}
