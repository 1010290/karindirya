using UnityEngine;
using System.Collections;

public class MoveFoodScript : MonoBehaviour
{
    public int occupiedSlot = 0;
    public string mouseControlled = "n";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        occupiedSlot = GMObjScript.selectedSlot;
        Debug.Log(occupiedSlot); //DELETE LATER
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseControlled == "y")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
        
    }

    void OnMouseDown()
    {
        mouseControlled = "y";
    }

}
