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
	public int[] HighScore = new int[14];

	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey ("FirstBlood")) {
			Debug.Log("InitNew");
			InitializePlayerPref();
			InitializeData();
		}
		else {
			Debug.Log("InitFromPref");
			ReadDataFromPlayerPref();
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
		PlayerPrefs.SetInt ("HS00", 0);
		PlayerPrefs.SetInt ("HS01", 0);
		PlayerPrefs.SetInt ("HS02", 0);
		PlayerPrefs.SetInt ("HS03", 0);
		PlayerPrefs.SetInt ("HS04", 0);
		PlayerPrefs.SetInt ("HS05", 0);
		PlayerPrefs.SetInt ("HS06", 0);
		PlayerPrefs.SetInt ("HS07", 0);
		PlayerPrefs.SetInt ("HS08", 0);
		PlayerPrefs.SetInt ("HS09", 0);
		PlayerPrefs.SetInt ("HS10", 0);
		PlayerPrefs.SetInt ("HS11", 0);
		PlayerPrefs.SetInt ("HS12", 0);
		PlayerPrefs.SetInt ("HS13", 0);
	}

	void InitializeData(){
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
		HighScore [0] = 0;
		HighScore [1] = 0;
		HighScore [2] = 0;
		HighScore [3] = 0;
		HighScore [4] = 0;
		HighScore [5] = 0;
		HighScore [6] = 0;
		HighScore [7] = 0;
		HighScore [8] = 0;
		HighScore [9] = 0;
		HighScore [10] = 0;
		HighScore [11] = 0;
		HighScore [12] = 0;
		HighScore [13] = 0;
	}

	void ReadDataFromPlayerPref(){
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
		HighScore [0] = PlayerPrefs.GetInt ("HS00");
		HighScore [1] = PlayerPrefs.GetInt ("HS01");
		HighScore [2] = PlayerPrefs.GetInt ("HS02");
		HighScore [3] = PlayerPrefs.GetInt ("HS03");
		HighScore [4] = PlayerPrefs.GetInt ("HS04");
		HighScore [5] = PlayerPrefs.GetInt ("HS05");
		HighScore [6] = PlayerPrefs.GetInt ("HS06");
		HighScore [7] = PlayerPrefs.GetInt ("HS07");
		HighScore [8] = PlayerPrefs.GetInt ("HS08");
		HighScore [9] = PlayerPrefs.GetInt ("HS09");
		HighScore [10] = PlayerPrefs.GetInt ("HS10");
		HighScore [11] = PlayerPrefs.GetInt ("HS11");
		HighScore [12] = PlayerPrefs.GetInt ("HS12");
		HighScore [13] = PlayerPrefs.GetInt ("HS13");
	}

	public void SaveDataToPlayerPref(){
		PlayerPrefs.SetInt ("C00", BIConvert (CharacterLockTracker [0]));
		PlayerPrefs.SetInt ("C01", BIConvert (CharacterLockTracker [1]));
		PlayerPrefs.SetInt ("C02", BIConvert (CharacterLockTracker [2]));
		PlayerPrefs.SetInt ("C03", BIConvert (CharacterLockTracker [3]));
		PlayerPrefs.SetInt ("C04", BIConvert (CharacterLockTracker [4]));
		PlayerPrefs.SetInt ("C05", BIConvert (CharacterLockTracker [5]));
		PlayerPrefs.SetInt ("C06", BIConvert (CharacterLockTracker [6]));
		PlayerPrefs.SetInt ("C07", BIConvert (CharacterLockTracker [7]));
		PlayerPrefs.SetInt ("C08", BIConvert (CharacterLockTracker [8]));
		PlayerPrefs.SetInt ("C09", BIConvert (CharacterLockTracker [9]));
		PlayerPrefs.SetInt ("C10", BIConvert (CharacterLockTracker [10]));
		PlayerPrefs.SetInt ("C11", BIConvert (CharacterLockTracker [11]));
		PlayerPrefs.SetInt ("C12", BIConvert (CharacterLockTracker [12]));
		PlayerPrefs.SetInt ("C13", BIConvert (CharacterLockTracker [13]));
		PlayerPrefs.SetInt ("HS00", HighScore [0]);
		PlayerPrefs.SetInt ("HS01", HighScore [1]);
		PlayerPrefs.SetInt ("HS02", HighScore [2]);
		PlayerPrefs.SetInt ("HS03", HighScore [3]);
		PlayerPrefs.SetInt ("HS04", HighScore [4]);
		PlayerPrefs.SetInt ("HS05", HighScore [5]);
		PlayerPrefs.SetInt ("HS06", HighScore [6]);
		PlayerPrefs.SetInt ("HS07", HighScore [7]);
		PlayerPrefs.SetInt ("HS08", HighScore [8]);
		PlayerPrefs.SetInt ("HS09", HighScore [9]);
		PlayerPrefs.SetInt ("HS10", HighScore [10]);
		PlayerPrefs.SetInt ("HS11", HighScore [11]);
		PlayerPrefs.SetInt ("HS12", HighScore [12]);
		PlayerPrefs.SetInt ("HS13", HighScore [13]);
		PlayerPrefs.Save ();
	}

	public void ClearAllData(){
		InitializeData ();
		InitializePlayerPref();
	}
	
	bool IBconvert(int num){
		if (num == 1)
			return false;
		else 
			return true;
	}

	int BIConvert(bool bit){
		if (bit == true)
			return 0;
		else
			return 1;
	}

	public bool CharacterLockStatus(int CharacterNum){
		return CharacterLockTracker[CharacterNum];
	}

	public void UnlockCharacter(int CharacterNum){
		CharacterLockTracker [CharacterNum] = true;
		return;
	}

	public void setHighScore(string birdName, int newScore){
		int birdID = 0;
		switch (birdName) {
		case("Original"):
			birdID = 0;
			break;
		case("MeiGuang"):
			birdID = 1;
			break;
		case("BaoZiRuQin"):
			birdID = 2;
			break;
		case("YeYuShengFan"):
			birdID = 3;
			break;
		case("SuoKeSaEr"):
			birdID = 4;
			break;
		case("WangBuLiuXing"):
			birdID = 5;
			break;
		case("BaiHuaLiaoLuan"):
			birdID = 6;
			break;
		case ("FengShanGuiQi"):
			birdID = 7;
			break;
		case ("YiYeZhiQiu"):
			birdID = 8;
			break;
		case ("YiQiangChuanYun"):
			birdID = 9;
			break;
		case("LengAnLei"):
			birdID = 10;
			break;
		case("ShiBuZhuan"):
			birdID = 11;
			break;
		case ("DaMoGuYan"):
			birdID = 12;
			break;
		case ("JunMoXiao"):
			birdID = 13;
			break;
		}
		if (newScore > HighScore [birdID]) {
			HighScore[birdID] = newScore;
		}
	}

	public int getHighScore(int birdID){
		return HighScore [birdID];
	}
}
