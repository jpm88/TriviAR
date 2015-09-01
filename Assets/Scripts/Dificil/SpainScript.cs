﻿using UnityEngine;
using System.Collections;

public class SpainScript : MonoBehaviour, ITrackableEventHandler {
	
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
			
			GUI.Box(caja, "¿Cómo se llama la Comunidad Autónoma marcada en naranja?");
			if (GUI.Button(boton1, "Extremadura")) {
				ScoreManager.SumaPuntos();
				Application.LoadLevel("AciertoDificil");
			}
			if (GUI.Button(boton2, "Navarra")) {
				ScoreManager.RestaPuntos();
				LifeManager.DecrementoVidas();
				Application.LoadLevel("FalloDificil");
			}
			if (GUI.Button(boton3, "Castilla la Mancha")) {
				ScoreManager.RestaPuntos();
				LifeManager.DecrementoVidas();
				Application.LoadLevel("FalloDificil");
			}
			if (GUI.Button(boton4, "Murcia")) {
				ScoreManager.RestaPuntos();
				LifeManager.DecrementoVidas();
				Application.LoadLevel("FalloDificil");
			}
		}
	}
}