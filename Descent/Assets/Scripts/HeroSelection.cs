using UnityEngine;
using System.Collections;

public class HeroSelection : MonoBehaviour {

    public Camera myCamera; // The scenes camera    
    private GameObject parent; // The parent object to keep all instantiated objects

    // Use this for initialization
    void Start()
    {
        parent = GameObject.Find("Heroes"); // This finds the empty game object of parent.

        if (parent == null) // If not in the scene for any reason, this code will create it.
        {
            parent = new GameObject("Heroes");
        }
    }
   
    void Update ()
    {
       
	}

    void OnMouseDown()
    {
        Vector2 rawPos = CalculateWorldPointOfMouseClicked();
        Vector2 roundedPos = SnapToGrid(rawPos);
        GameObject hero = HeroButton.heroSelected;

        SpawnHero(roundedPos, hero);        
    }

    private void SpawnHero(Vector2 roundedPos, GameObject hero)
    {
        GameObject newHero = Instantiate(hero, roundedPos, Quaternion.identity) as GameObject;
        newHero.transform.parent = parent.transform;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }
    
    private Vector2 CalculateWorldPointOfMouseClicked ()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);

        return worldPos;        
    }
}
