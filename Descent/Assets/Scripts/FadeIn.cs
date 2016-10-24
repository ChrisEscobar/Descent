using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

    public float fadeInTime; // How long the fade in is after the splash screen.
    private Image fadePanel; // The fade panel itself.
    private Color currentColor = Color.black; // the initial colour of the panel.

	// Use this for initialization
	void Start ()
    {
        fadePanel = GetComponent<Image>(); // find the panel.
	}	
	
	void Update ()
    {
	    if(Time.timeSinceLevelLoad < fadeInTime) // if the time since the start of the scene is less than the fade in time created trun the alpha change.
        {
            float alphaChange = Time.deltaTime / fadeInTime; // set the amount to change the alpha (Time divided by the fade in time set).
            currentColor.a -= alphaChange; // Take away the alphaChange from tue "a" value of the current color (changes its opacity).
            fadePanel.color = currentColor; 
        }
        else
        {
            gameObject.SetActive(false); // remove the panel once fade in time is complete.
        }
	}
}
