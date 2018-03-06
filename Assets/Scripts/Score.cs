using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text txtScore;
	public Text highScore;
	void Start(){
		highScore.text = "HighScore: " + PlayerPrefs.GetInt ("HighScore",0).ToString ();
		StartCoroutine (pontos ());

	}
	void Update(){

		txtScore.text = "Score:" + MainScript.pontos;
		if (MainScript.pontos > PlayerPrefs.GetInt("HighScore",0)) {
			PlayerPrefs.SetInt ("HighScore", MainScript.pontos);
			//Atualizacao junta cm o score
			//highScore.text = "HighScore: " + MainScript.pontos.ToString ();
		}

                        vc
	}
	IEnumerator pontos(){
		yield return new WaitForSeconds (0.3f);
		MainScript.pontos++;
		StartCoroutine (pontos ());

	}
}
