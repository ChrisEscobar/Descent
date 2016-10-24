using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour
{

    const string MASTER_VOLUME_KEY = "master_volume";    

    public static void SetMasterVolume(float volume) // Method to set the master volume limits.
    {
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume); 
        }
        else
        {
            Debug.LogError("MASTER VOLUME OUT OF RANGE"); // error message if the volume has tried to be set out of the range used in the if statment.
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY); // Return the volume.
    }   
}
