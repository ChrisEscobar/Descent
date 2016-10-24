using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public AudioClip[] musicLevelChangeArray; // an array of music for each scene.
    private AudioSource audioSource; // a souce for the music.
	
    // Use this for initialization
	void Awake ()
    {
        DontDestroyOnLoad(gameObject); // this is so the music manager is never destroyed after the splash screen.
	}

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // finds the audio sources attached to the music manager.
    }

    // Update is called once per frame
    void OnLevelWasLoaded (int level) // stores the level number
    {
        AudioClip thisLevelsMusic = musicLevelChangeArray[level];        

        if(thisLevelsMusic)
        {
            audioSource.clip = thisLevelsMusic;
            audioSource.loop = true;
            audioSource.Play();
        }        
	}

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
