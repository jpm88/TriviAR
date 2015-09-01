using UnityEngine;
using System.Collections;

public class FailManager : MonoBehaviour {
	
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