using UnityEngine;

public class DeleteWhenClicked : MonoBehaviour
{
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
        //Destroy(gameObject);
        if (gameObject.name == "PlateDineIn")
        {
            if (GMObjScript.inventorySlot1 == "empty")
            {
                Destroy(gameObject);
                GMObjScript.inventorySlot1 = "empty";
            }
            else if (GMObjScript.inventorySlot2 == "empty")
            {
                Destroy(gameObject);
                GMObjScript.inventorySlot2 = "empty";
            }
            else if (GMObjScript.inventorySlot3 == "empty")
            {
                Destroy(gameObject);
                GMObjScript.inventorySlot3 = "empty";
            } //Close if-else statements
        }
    }
}
