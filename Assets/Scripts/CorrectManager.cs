using UnityEngine;
using System.Collections;

public class CorrectManager : MonoBehaviour {

	void Start(){
		ScoreManager.suma = 20;
	}

	public void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) 
			Application.LoadLevel ("Submenu");
	}
	
	public void ModoFacil () {
		Application.LoadLevel("Facil");
	}
	
	public void ModoDificil () {
		Application.LoadLevel("Dificil");
	}
	
}