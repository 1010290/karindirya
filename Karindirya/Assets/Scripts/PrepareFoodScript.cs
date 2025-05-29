using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Data;

public class PrepareFoodScript : MonoBehaviour
{

    public int occupiedSlot = 100;

    void Update()
    {
        if (occupiedSlot == GMObjScript.selectedDish)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
    } 

    void OnMouseDown()
    {
        /*
        if (GMObjScript.inventorySlot1 == "fullplate")
        {
            GMObjScript.inventorySlot1 = "servableDish";
            occupiedSlot = 1;
        }
        else if (GMObjScript.inventorySlot2 == "fullplate")
        {
            GMObjScript.inventorySlot2 = "servableDish";
            occupiedSlot = 2;
        }
        else if (GMObjScript.inventorySlot3 == "fullplate")
        {
            GMObjScript.inventorySlot3 = "servableDish";
            occupiedSlot = 3;
        }
        */
        
    }
}
