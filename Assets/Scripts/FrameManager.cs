using UnityEngine;
using System.Collections;

public class FrameManager : MonoBehaviour, ITrackableEventHandler {
	
	private TrackableBehaviour figura;
	
	public GUISkin customskin;
	public Texture2D frame;
	
	private bool mShowGUI = true;
	private Rect texto  = new Rect(15,100,510,70),
				 imagen = new Rect(120,175,300,300);
	
	void Start () {
		figura = GetComponent<TrackableBehaviour>();
		if (figura) {
			figura.RegisterTrackableEventHandler (this);
		}
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) 
			Application.LoadLevel ("Submenu"); 
	}
	
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED)
		{
			mShowGUI = false;
		}
		else
		{
			mShowGUI = true;
		}
	}
	

	void OnGUI() {
		GUI.skin = customskin;
		if (mShowGUI) {
			GUI.Label (texto, "Coloca el QR en la marca");
			GUI.DrawTexture (imagen, frame, ScaleMode.StretchToFill);
		}
	}
}