using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	
	public void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) 
			Application.LoadLevel ("Titulo");
	}
	
	public void Inicio (){
		Application.LoadLevel ("Titulo");
	}
	
	public void Empezar (){
		Application.LoadLevel ("Submenu");
	}
	
	public void Salir (){
		Application.Quit ();
	}
	
	public void ModoFacil () {
		Application.LoadLevel("Facil");
	}
	
	public void ModoDificil () {
		Application.LoadLevel("Dificil");
	}
	
}