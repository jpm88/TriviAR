﻿using UnityEngine;
using System.Collections;

public class PlaneScript : MonoBehaviour, ITrackableEventHandler {

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
			
			GUI.Box(caja, "¿Por dónde viaja el avión?");
			if (GUI.Button(boton1, "Por mar")) {
				ScoreManager.RestaPuntos();
				Application.LoadLevel("Fallo");
			}
			if (GUI.Button(boton2, "Por carretera")) {
				ScoreManager.RestaPuntos();
				Application.LoadLevel("Fallo");
			}
			if (GUI.Button(boton3, "Por aire")) {
				ScoreManager.SumaPuntos();
				Application.LoadLevel("Acierto");
			}
			if (GUI.Button(boton4, "Bajo tierra")) {
				ScoreManager.RestaPuntos();
				Application.LoadLevel("Fallo");
			}
		}
	}
}