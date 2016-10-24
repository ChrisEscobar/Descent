using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

    /// This code is so the splash screen jingle is never effected by a change in volume in the options
    
    private MusicManager musicManager;    

	// Use this for initialization
	void Start ()
    {

        musicManager = GameObject.FindObjectOfType<MusicManager>();

        if (musicManager)
        {            
            float volume = PlayerPrefsManager.GetMasterVolume();
            musicManager.SetVolume(volume);
        }
        else
            Debug.LogError("No music manager in scene");
        
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
