using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuestionManager : MonoBehaviour {
	
	public static int numero;
	
	Text text;
	
	void Start () {
		text = GetComponent <Text> ();	
	}

	void Update () {
		text.text = "Pregunta  " + numero;
	}

	public void IncrementoPregunta(){
		numero += 1;
	}

	public void ResultadosFacil(){
		if (numero > 5) {
			Application.LoadLevel ("ResultadoFacil");
		}
	}

	public void ResultadosDificil(){
		if (numero > 5) {
			Application.LoadLevel ("ResultadoDificil");
		}
	}
}