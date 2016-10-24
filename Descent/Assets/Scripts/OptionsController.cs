using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider; // the volume slider used in the options menu.
    public LevelManager levelManager; // access to the levelmanager.
    private MusicManager musicManager; // access to the music manager.

    // Use this for initialization
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>(); // find the music manager.
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume(); // get the set master volume from the playerprefs code.
    }

    // Update is called once per frame
    void Update()
    {
        musicManager.SetVolume(volumeSlider.value); // set the volume to what is chosen on the slider.

    }

    public void SaveAndExit() // method used on the back button to save the volume set.
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);        
        levelManager.LoadLevel("01a Start"); // return to the start menu.       
    }

    public void SetDefaults() // method to use the default volume.
    {
        volumeSlider.value = 0.8f; // changed volume to a set level.
    }
}
