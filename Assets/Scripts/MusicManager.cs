using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	
	static bool AudioBegin = false;
	GameObject otherSound;
	
	void Awake()
	{
		otherSound = GameObject.Find("Audio");
		
		if (otherSound == this.gameObject)
		{
			if (!AudioBegin)
			{
				DontDestroyOnLoad(this.gameObject);
				AudioBegin = true;
			}
		}
		else
		{
			Destroy(this.gameObject);
		}
		
		
		
	}
}