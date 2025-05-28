using UnityEngine;
using System.Collections;

public class DishControlScript : MonoBehaviour
{
    //Checks When a Dish/Plate/Plastic "Button" is Pressed
    public Transform arrozCaldoObj;
    public Transform tinolaObj;
    public Transform sisigObj;
    public Transform adoboObj;
    public Transform lumpiaObj;
    public Transform menudoObj;
    public Transform plasticObj;
    public Transform plateObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gameObject.name == "PlateDineIn")
        {
            if (GMObjScript.inventorySlot1 == "empty")
            {
                Instantiate(plateObj, new Vector2(-1.25f, -4.06f), plateObj.rotation);
                GMObjScript.inventorySlot1 = "plate";
            }
            else if (GMObjScript.inventorySlot2 == "empty")
            {
                Instantiate(plateObj, new Vector2(1.11f, -4.06f), plateObj.rotation);
                GMObjScript.inventorySlot2 = "plate";
            }
            else if (GMObjScript.inventorySlot3 == "empty")
            {
                Instantiate(plateObj, new Vector2(3.37f, -4.06f), plateObj.rotation);
                GMObjScript.inventorySlot3 = "plate";
            } //Close if-else statements
        }



        if (gameObject.name == "TinolaObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                Instantiate(tinolaObj, new Vector2(-1.25f, -4.06f), tinolaObj.rotation);
                GMObjScript.inventorySlot1 = "fullplate";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                Instantiate(tinolaObj, new Vector2(1.11f, -4.06f), tinolaObj.rotation);
                GMObjScript.inventorySlot2 = "fullplate";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                Instantiate(tinolaObj, new Vector2(3.37f, -4.06f), tinolaObj.rotation);
                GMObjScript.inventorySlot3 = "fullplate";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }
    }
}
