using UnityEngine;
using System.Collections;

public class DataAgent : MonoBehaviour {
	static DataAgent _instance;

	static public DataAgent instance
	{
		get{
			if (_instance == null){
				_instance = Object.FindObjectOfType<DataAgent>();
				DontDestroyOnLoad(_instance.gameObject);
			}
			return _instance;
		}
	}

	public bool[] CharacterLockTracker = new bool[14];

	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey ("FirstBlood")) {
			Debug.Log("InitNew");
			InitializePlayerPref();
			InitializePlayerLockStatus();
		}
		else {
			Debug.Log("InitFromPref");
			ReadLockStatusFromPlayerPref();
		}
	}

	void Awake(){
		if (_instance == null) {
			_instance = this;
			DontDestroyOnLoad (this);
		} 
		else{
			if (this != _instance)
			Destroy (this.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

	void InitializePlayerPref(){
		PlayerPrefs.SetString("FirstBlood", "DoubleKill!");
		PlayerPrefs.SetInt ("C00", 0);
		PlayerPrefs.SetInt ("C01", 1);
		PlayerPrefs.SetInt ("C02", 1);
		PlayerPrefs.SetInt ("C03", 1);
		PlayerPrefs.SetInt ("C04", 1);
		PlayerPrefs.SetInt ("C05", 1);
		PlayerPrefs.SetInt ("C06", 1);
		PlayerPrefs.SetInt ("C07", 1);
		PlayerPrefs.SetInt ("C08", 1);
		PlayerPrefs.SetInt ("C09", 1);
		PlayerPrefs.SetInt ("C10", 1);
		PlayerPrefs.SetInt ("C11", 1);
		PlayerPrefs.SetInt ("C12", 1);
		PlayerPrefs.SetInt ("C13", 1);
	}

	void InitializePlayerLockStatus(){
		CharacterLockTracker [0] = true;
		CharacterLockTracker [1] = false;
		CharacterLockTracker [2] = false;
		CharacterLockTracker [3] = false;
		CharacterLockTracker [4] = false;
		CharacterLockTracker [5] = false;
		CharacterLockTracker [6] = false;
		CharacterLockTracker [7] = false;
		CharacterLockTracker [8] = false;
		CharacterLockTracker [9] = false;
		CharacterLockTracker [10] = false;
		CharacterLockTracker [11] = false;
		CharacterLockTracker [12] = false;
		CharacterLockTracker [13] = false;
	}

	void ReadLockStatusFromPlayerPref(){
		CharacterLockTracker[0] = IBconvert(PlayerPrefs.GetInt("C00"));
		CharacterLockTracker[1] = IBconvert(PlayerPrefs.GetInt("C01"));
		CharacterLockTracker[2] = IBconvert(PlayerPrefs.GetInt("C02"));
		CharacterLockTracker[3] = IBconvert(PlayerPrefs.GetInt("C03"));
		CharacterLockTracker[4] = IBconvert(PlayerPrefs.GetInt("C04"));
		CharacterLockTracker[5] = IBconvert(PlayerPrefs.GetInt("C05"));
		CharacterLockTracker[6] = IBconvert(PlayerPrefs.GetInt("C06"));
		CharacterLockTracker[7] = IBconvert(PlayerPrefs.GetInt("C07"));
		CharacterLockTracker[8] = IBconvert(PlayerPrefs.GetInt("C08"));
		CharacterLockTracker[9] = IBconvert(PlayerPrefs.GetInt("C09"));
		CharacterLockTracker[10] = IBconvert(PlayerPrefs.GetInt("C10"));
		CharacterLockTracker[11] = IBconvert(PlayerPrefs.GetInt("C11"));
		CharacterLockTracker[12] = IBconvert(PlayerPrefs.GetInt("C12"));
		CharacterLockTracker[13] = IBconvert(PlayerPrefs.GetInt("C13"));
	}



	bool IBconvert(int num){
		if (num == 1)
			return false;
		else 
			return true;
	}

	public bool CharacterLockStatus(int CharacterNum){
		return CharacterLockTracker[CharacterNum];
	}

	public void UnlockCharacter(int CharacterNum){
		CharacterLockTracker [CharacterNum] = true;
		return;
	}
}
