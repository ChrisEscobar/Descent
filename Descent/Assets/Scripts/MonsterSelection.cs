using UnityEngine;
using System.Collections;

public class MonsterSelection : MonoBehaviour {

    public Camera myCamera;
    private GameObject parent;

    // Use this for initialization
    void Start()
    {
        parent = GameObject.Find("Monsters");

        if (parent == null)
        {
            parent = new GameObject("Monsters");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Vector2 rawPos = CalculateWorldPointOfMouseClicked();
        Vector2 roundedPos = SnapToGrid(rawPos);
        GameObject monster = MonsterButton.monsterSelected;

        SpawnMonster(roundedPos, monster);
    }

    private void SpawnMonster(Vector2 roundedPos, GameObject monster)
    {
        GameObject newMonster = Instantiate(monster, roundedPos, Quaternion.identity) as GameObject;
        newMonster.transform.parent = parent.transform;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }

    private Vector2 CalculateWorldPointOfMouseClicked()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);

        return worldPos;
    }
}
