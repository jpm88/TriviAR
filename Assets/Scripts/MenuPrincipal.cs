using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour {

	public void Start(){
		ScoreManager.score = 0;
		ScoreManager.suma = 20;
		LifeManager.lifes = 5;
		QuestionManager.numero = 1;
	}


	public void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) 
			Application.Quit ();
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
