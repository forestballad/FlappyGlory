using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YiQiangChuanYunGameControl : MonoBehaviour {
	public Text scoreText;
	public int score;

	// Use this for initialization
	void Start () {
		score = 10000;
		scoreText.GetComponent<Text> ().text = score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		score -= 10;
		scoreText.GetComponent<Text> ().text = score.ToString ();
	}
}
