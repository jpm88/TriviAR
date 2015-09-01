using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int score;

	public static int suma;

	Text text;
	
	void Start () {
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Puntos: " + score;
	}

	public static void SumaPuntos(){
		score += suma;
	}

	public static void RestaPuntos(){
		suma -= 5;
	}

	public void FinalError(){
		if (score < 0) {
			Application.LoadLevel ("GameOver");
		}
	}
}
