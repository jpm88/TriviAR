using UnityEngine;
using System.Collections;

public class PhoneScript : MonoBehaviour, ITrackableEventHandler {
	
	private TrackableBehaviour figura;
	
	public GUISkin customskin;
	
	private bool mShowGUI = false;
	private Rect caja   = new Rect(15,560,510,70),
	boton1 = new Rect(15,650,250,100),
	boton2 = new Rect(275,650,250,100),
	boton3 = new Rect(15,775,250,100),
	boton4 = new Rect(275,775,250,100);
	
	void Start () {
		figura = GetComponent<TrackableBehaviour>();
		if (figura)
		{
			figura.RegisterTrackableEventHandler(this);
		}
	}
	
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED)
		{
			mShowGUI = true;
		}
		else
		{
			mShowGUI = false;
		}
	}
	
	
	void OnGUI() {
		if (mShowGUI) {
			GUI.skin = customskin;
			
			GUI.Box(caja, "¿Qué onomatopeya corresponde al teléfono?");
			if (GUI.Button(boton1, "¡Brum-brum!")) {
				ScoreManager.RestaPuntos();
				Application.LoadLevel("Fallo");
			}
			if (GUI.Button(boton2, "¡Ring-ring!")) {
				ScoreManager.SumaPuntos();
				Application.LoadLevel("Acierto");
			}
			if (GUI.Button(boton3, "Tic-tac, tic-tac")) {
				ScoreManager.RestaPuntos();
				Application.LoadLevel("Fallo");
			}
			if (GUI.Button(boton4, "¡BOOM!")) {
				ScoreManager.RestaPuntos();
				Application.LoadLevel("Fallo");
			}
		}
	}
}