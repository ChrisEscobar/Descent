using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public float autoStartAfterTime;

    void Awake() // Bit of code to automatically load the start screen after the splash screen
    {
        if(autoStartAfterTime <= 0) // Set ther value of AutoStartAfterTime to 0 on the start screen, so it stops the auto scene loading.
        {
            Debug.Log("level auto load disabled"); // lets us know the level will no longer auto load
        }
        else
        Invoke("loadNextLevel", autoStartAfterTime); // Set the splash screen value of AutoStartAfterTime to 3 so it runs this else statement, and auto loads.
    }

    public void LoadLevel(string name) // Load level method used for UI menu buttons.
    {
        Application.LoadLevel(name);
    }

    public void QuitRequest() // Quit application method used for UI menu buttons
    {
        Debug.Log("Quit Requested");
        Application.Quit();
    }

    public void loadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1); // auto load next scene in order of scenes in build settings.
    }
}
