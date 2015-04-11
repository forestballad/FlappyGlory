using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreMenuControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("HighScoreText_Original").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (0).ToString();
		GameObject.Find ("HighScoreText_MeiGuang").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (1).ToString();
		GameObject.Find ("HighScoreText_BaoZiRuQin").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (2).ToString();
		GameObject.Find ("HighScoreText_YeYuShengFan").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (3).ToString();
		GameObject.Find ("HighScoreText_SuoKeSaEr").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (4).ToString();
		GameObject.Find ("HighScoreText_WangBuLiuXing").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (5).ToString();
		GameObject.Find ("HighScoreText_BaiHuaLiaoLuan").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (6).ToString();
		GameObject.Find ("HighScoreText_FengShanGuiQi").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (7).ToString();
		GameObject.Find ("HighScoreText_YiYeZhiQiu").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (8).ToString();
		GameObject.Find ("HighScoreText_YiQiangChuanYun").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (9).ToString();
		GameObject.Find ("HighScoreText_LengAnLei").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (10).ToString();
		GameObject.Find ("HighScoreText_ShiBuZhuan").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (11).ToString();
		GameObject.Find ("HighScoreText_DaMoGuYan").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (12).ToString();
		GameObject.Find ("HighScoreText_JunMoXiao").GetComponent<Text> ().text = GameObject.Find ("DataAgentObject").GetComponent<DataAgent> ().getHighScore (13).ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
