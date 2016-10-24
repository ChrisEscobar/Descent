using UnityEngine;
using System.Collections;

public class MonsterButton : MonoBehaviour {

    public GameObject monsterPrefab; // Slot to assign the specific monster prefab
    private MonsterButton[] buttonArray2; // the array of buttons within the monster button parent
    public static GameObject monsterSelected; // The one instance of the monster selection

    // Use this for initialization
    void Start()
    {
        buttonArray2 = GameObject.FindObjectsOfType<MonsterButton>(); // find the monster button object and assign it to the button array  
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        foreach (MonsterButton thisButton in buttonArray2) // loop through the buttons and make all the images black
        {
            thisButton.GetComponent<SpriteRenderer>().color = Color.black; // change sprite of button to black (Sillohette)
        }

        gameObject.GetComponent<SpriteRenderer>().color = Color.white; // when clicked, change button to white (shows colour)

        monsterSelected = monsterPrefab; // set the monster selection to the monster prefab.
        HeroButton.heroSelected = monsterSelected; // counter act the Hero button script to stop it creating a hero aswell.

        print(monsterSelected); // show the console what has been selected.
    }
}
