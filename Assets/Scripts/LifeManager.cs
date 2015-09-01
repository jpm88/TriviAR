using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeManager : MonoBehaviour {
	
	public static int lifes;
	
	Text text;
	
	void Start () {
		text = GetComponent <Text> ();
	}

	void Update () {
		text.text = "Vidas: " + lifes;
	}

	public static void DecrementoVidas(){
		lifes -= 1;
	}

	public void FinalJuego(){
		if (lifes == 0) {
			Application.LoadLevel ("GameOver");
		}
	}
}
