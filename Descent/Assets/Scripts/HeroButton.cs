using UnityEngine;
using System.Collections;

public class HeroButton : MonoBehaviour {

    public GameObject heroPrefab; // Slot to assign the specific hero prefab
    private HeroButton[] buttonArray1; // the array of buttons within the hero button parent

    public static GameObject heroSelected; // The one instance of the hero selection

    // Use this for initialization
	void Start ()
    {
        buttonArray1 = GameObject.FindObjectsOfType<HeroButton>(); // find the hero button object and assign it to the button array       
	}	
	
	void Update ()
    {
	
	}

    void OnMouseDown()
    {
        foreach(HeroButton thisButton in buttonArray1) // loop through the buttons and make all the images black
        {
            thisButton.GetComponent<SpriteRenderer>().color = Color.black; // change sprite of button to black (Sillohette)
        }

        gameObject.GetComponent<SpriteRenderer>().color = Color.white; // when clicked, change button to white (shows colour)

        heroSelected = heroPrefab; // set the hero selection to the hero prefab.
        MonsterButton.monsterSelected = heroSelected; // counter act the monster button script to stop it creating a monster aswell.

        print(heroSelected); // show the console what has been selected.
    }
}
