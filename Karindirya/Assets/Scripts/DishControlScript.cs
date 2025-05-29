using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.Composites;

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
    public Transform arrozCaldoTakeOutObj;
    public Transform tinolaTakeOutObj;
    public Transform sisigTakeOutObj;
    public Transform adoboTakeOutObj;
    public Transform lumpiaTakeOutObj;
    public Transform menudoTakeOutObj;


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
                Instantiate(plateObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "plate";
            }
            else if (GMObjScript.inventorySlot2 == "empty")
            {
                Instantiate(plateObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "plate";
            }
            else if (GMObjScript.inventorySlot3 == "empty")
            {
                Instantiate(plateObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "plate";
            } //Close if-else statements
        }

        if (gameObject.name == "PlasticTakeOut")
        {
            if (GMObjScript.inventorySlot1 == "empty")
            {
                Instantiate(plasticObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "plastic";
            }
            else if (GMObjScript.inventorySlot2 == "empty")
            {
                Instantiate(plasticObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "plastic";
            }
            else if (GMObjScript.inventorySlot3 == "empty")
            {
                Instantiate(plasticObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "plastic";
            } //Close if-else statements
        }

        if (gameObject.name == "TinolaObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                Instantiate(tinolaObj, new Vector2(-1.25f, -4.06f), tinolaObj.rotation);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                Instantiate(tinolaObj, new Vector2(1.11f, -4.06f), tinolaObj.rotation);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                Instantiate(tinolaObj, new Vector2(3.37f, -4.06f), tinolaObj.rotation);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "ArrozCaldoObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                Instantiate(arrozCaldoObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                Instantiate(arrozCaldoObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                Instantiate(arrozCaldoObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "SisigObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                Instantiate(sisigObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                Instantiate(sisigObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                Instantiate(sisigObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "AdoboObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                Instantiate(adoboObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                Instantiate(adoboObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                Instantiate(adoboObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "LumpiaObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                Instantiate(lumpiaObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                Instantiate(lumpiaObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                Instantiate(lumpiaObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "MenudoObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                Instantiate(menudoObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                Instantiate(menudoObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                Instantiate(menudoObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "tinolaObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                Instantiate(tinolaTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                Instantiate(tinolaTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                Instantiate(tinolaTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "ArrozCaldoObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                Instantiate(arrozCaldoTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                Instantiate(arrozCaldoTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                Instantiate(arrozCaldoTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "SisigObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                Instantiate(sisigTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                Instantiate(sisigTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                Instantiate(sisigTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "AdoboObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                Instantiate(lumpiaTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                Instantiate(lumpiaTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                Instantiate(lumpiaTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "LumpiaObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                Instantiate(lumpiaTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                Instantiate(lumpiaTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                Instantiate(lumpiaTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "MenudoObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                Instantiate(menudoTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                Instantiate(menudoTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                Instantiate(menudoTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "PlateSisig(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = new Vector3(-22.72f, -1.16f);
                //transform.position = Vector3.Slerp(-22.72f, -1.16f, 10f * Time.deltaTime);
                GMObjScript.inventorySlot1 = "plate";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                Instantiate(menudoTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "plate";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                Instantiate(menudoTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "plate";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }
    }
}
