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
    Vector2 counterSlot1 = new Vector2(-22.72f, -1.16f);
    Vector2 counterSlot2 = new Vector2(-18.26f, -1.16f);
    Vector2 counterSlot3 = new Vector2(-13.67f, -1.16f);
    Vector2 orderReceiver = new Vector2(-13.46f, 1.707504f);


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
                Transform plateOne = Instantiate(plateObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "plate";
                plateOne.name = "emptyPlateOne";
            }
            else if (GMObjScript.inventorySlot2 == "empty")
            {
                Transform plateTwo = Instantiate(plateObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "plate";
                plateTwo.name = "emptyPlateTwo";
            }
            else if (GMObjScript.inventorySlot3 == "empty")
            {
                Transform plateThree = Instantiate(plateObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "plate";
                plateThree.name = "emptyPlateThree";
            } //Close if-else statements
        }

        if (gameObject.name == "PlasticTakeOut")
        {
            if (GMObjScript.inventorySlot1 == "empty")
            {
                Transform plasticOne = Instantiate(plasticObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "plastic";
                plasticOne.name = "emptyPlasticOne";
            }
            else if (GMObjScript.inventorySlot2 == "empty")
            {
                Transform plasticTwo = Instantiate(plasticObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "plastic";
                plasticTwo.name = "emptyPlasticTwo";
            }
            else if (GMObjScript.inventorySlot3 == "empty")
            {
                Transform plasticThree = Instantiate(plasticObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "plastic";
                plasticThree.name = "emptyPlasticThree";
            } //Close if-else statements
        }

        //GENERATE DISH ON A PLATE
        if (gameObject.name == "TinolaObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                GameObject plateToDestroyOne = GameObject.Find("emptyPlateOne");
                Destroy(plateToDestroyOne);
                Instantiate(tinolaObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                GameObject plateToDestroyTwo = GameObject.Find("emptyPlateTwo");
                Destroy(plateToDestroyTwo);
                Instantiate(tinolaObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                GameObject plateToDestroyThree = GameObject.Find("emptyPlateThree");
                Destroy(plateToDestroyThree);
                Instantiate(tinolaObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "ArrozCaldoObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                GameObject plateToDestroyOne = GameObject.Find("emptyPlateOne");
                Destroy(plateToDestroyOne);
                Instantiate(arrozCaldoObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                GameObject plateToDestroyTwo = GameObject.Find("emptyPlateTwo");
                Destroy(plateToDestroyTwo);
                Instantiate(arrozCaldoObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                GameObject plateToDestroyThree = GameObject.Find("emptyPlateThree");
                Destroy(plateToDestroyThree);
                Instantiate(arrozCaldoObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "SisigObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                GameObject plateToDestroyOne = GameObject.Find("emptyPlateOne");
                Destroy(plateToDestroyOne);
                Instantiate(sisigObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                GameObject plateToDestroyTwo = GameObject.Find("emptyPlateTwo");
                Destroy(plateToDestroyTwo);
                Instantiate(sisigObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                GameObject plateToDestroyThree = GameObject.Find("emptyPlateThree");
                Destroy(plateToDestroyThree);
                Instantiate(sisigObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "AdoboObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                GameObject plateToDestroyOne = GameObject.Find("emptyPlateOne");
                Destroy(plateToDestroyOne);
                Instantiate(adoboObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                GameObject plateToDestroyTwo = GameObject.Find("emptyPlateTwo");
                Destroy(plateToDestroyTwo);
                Instantiate(adoboObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                GameObject plateToDestroyThree = GameObject.Find("emptyPlateThree");
                Destroy(plateToDestroyThree);
                Instantiate(adoboObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "LumpiaObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                GameObject plateToDestroyOne = GameObject.Find("emptyPlateOne");
                Destroy(plateToDestroyOne);
                Instantiate(lumpiaObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                GameObject plateToDestroyTwo = GameObject.Find("emptyPlateTwo");
                Destroy(plateToDestroyTwo);
                Instantiate(lumpiaObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                GameObject plateToDestroyThree = GameObject.Find("emptyPlateThree");
                Destroy(plateToDestroyThree);
                Instantiate(lumpiaObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "MenudoObj")
        {
            if (GMObjScript.inventorySlot1 == "plate")
            {
                GameObject plateToDestroyOne = GameObject.Find("emptyPlateOne");
                Destroy(plateToDestroyOne);
                Instantiate(menudoObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plate")
            {
                GameObject plateToDestroyTwo = GameObject.Find("emptyPlateTwo");
                Destroy(plateToDestroyTwo);
                Instantiate(menudoObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plate")
            {
                GameObject plateToDestroyThree = GameObject.Find("emptyPlateThree");
                Destroy(plateToDestroyThree);
                Instantiate(menudoObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        //GENERATE DISH IN A TAKEOUT PLASTIC
        if (gameObject.name == "TinolaObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                GameObject plasticToDestroyOne = GameObject.Find("emptyPlasticOne");
                Destroy(plasticToDestroyOne);
                Instantiate(tinolaTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                GameObject plasticToDestroyTwo = GameObject.Find("emptyPlasticTwo");
                Destroy(plasticToDestroyTwo);
                Instantiate(tinolaTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                GameObject plasticToDestroyThree = GameObject.Find("emptyPlasticThree");
                Destroy(plasticToDestroyThree);
                Instantiate(tinolaTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "ArrozCaldoObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                GameObject plasticToDestroyOne = GameObject.Find("emptyPlasticOne");
                Destroy(plasticToDestroyOne);
                Instantiate(arrozCaldoTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                GameObject plasticToDestroyTwo = GameObject.Find("emptyPlasticTwo");
                Destroy(plasticToDestroyTwo);
                Instantiate(arrozCaldoTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                GameObject plasticToDestroyThree = GameObject.Find("emptyPlasticThree");
                Destroy(plasticToDestroyThree);
                Instantiate(arrozCaldoTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "SisigObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                GameObject plasticToDestroyOne = GameObject.Find("emptyPlasticOne");
                Destroy(plasticToDestroyOne);
                Instantiate(sisigTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                GameObject plasticToDestroyTwo = GameObject.Find("emptyPlasticTwo");
                Destroy(plasticToDestroyTwo);
                Instantiate(sisigTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                GameObject plasticToDestroyThree = GameObject.Find("emptyPlasticThree");
                Destroy(plasticToDestroyThree);
                Instantiate(sisigTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "AdoboObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                GameObject plasticToDestroyOne = GameObject.Find("emptyPlasticOne");
                Destroy(plasticToDestroyOne);
                Instantiate(adoboTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                GameObject plasticToDestroyTwo = GameObject.Find("emptyPlasticTwo");
                Destroy(plasticToDestroyTwo);
                Instantiate(adoboTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                GameObject plasticToDestroyThree = GameObject.Find("emptyPlasticThree");
                Destroy(plasticToDestroyThree);
                Instantiate(adoboTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "LumpiaObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                GameObject plasticToDestroyOne = GameObject.Find("emptyPlasticOne");
                Destroy(plasticToDestroyOne);
                Instantiate(lumpiaTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                GameObject plasticToDestroyTwo = GameObject.Find("emptyPlasticTwo");
                Destroy(plasticToDestroyTwo);
                Instantiate(lumpiaTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                GameObject plasticToDestroyThree = GameObject.Find("emptyPlasticThree");
                Destroy(plasticToDestroyThree);
                Instantiate(lumpiaTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "MenudoObj")
        {
            if (GMObjScript.inventorySlot1 == "plastic")
            {
                GameObject plasticToDestroyOne = GameObject.Find("emptyPlasticOne");
                Destroy(plasticToDestroyOne);
                Instantiate(menudoTakeOutObj, new Vector2(-1.25f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot1 = "toServe";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "plastic")
            {
                GameObject plasticToDestroyTwo = GameObject.Find("emptyPlasticTwo");
                Destroy(plasticToDestroyTwo);
                Instantiate(menudoTakeOutObj, new Vector2(1.11f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot2 = "toServe";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "plastic")
            {
                GameObject plasticToDestroyThree = GameObject.Find("emptyPlasticThree");
                Destroy(plasticToDestroyThree);
                Instantiate(menudoTakeOutObj, new Vector2(3.37f, -4.06f), Quaternion.identity);
                GMObjScript.inventorySlot3 = "toServe";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        //MOVE PLATED DISH TO THE COUNTER
        if (gameObject.name == "PlateTinola(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "PlateArrozCaldo(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "PlateSisig(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "PlateAdobo(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "PlateLumpia(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "PlateMenudo(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        //MOVE TAKEOUT TO THE COUNTER
        if (gameObject.name == "TakeOutTinola(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "TakeOutArrozCaldo(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "TakeOutSisig(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "TakeOutAdobo(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "TakeOutLumpia(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.name == "TakeOutMenudo(Clone)")
        {
            if (GMObjScript.inventorySlot1 == "toServe")
            {
                transform.position = counterSlot1;
                GMObjScript.inventorySlot1 = "empty";
                GameObject menudoTakeOut = GameObject.Find("TakeOutMenudo(Clone)");
                menudoTakeOut.tag = "Servable";
                menudoTakeOut.name = "menudoTakeOut";
                GMObjScript.selectedSlot = 1;
            }
            else if (GMObjScript.inventorySlot2 == "toServe")
            {
                transform.position = counterSlot2;
                GMObjScript.inventorySlot2 = "empty";
                GMObjScript.selectedSlot = 2;
            }
            else if (GMObjScript.inventorySlot3 == "toServe")
            {
                transform.position = counterSlot3;
                GMObjScript.inventorySlot3 = "empty";
                GMObjScript.selectedSlot = 3;
            } //Close if-else statements
        }

        if (gameObject.tag == "ReadyToServe")
        {
            Debug.Log("ReadyToServe");
            transform.position = orderReceiver;
        }
        else if (gameObject.tag == "Servable")
        {
            GameObject menudoTakeOut = GameObject.Find("menudoTakeOut");
            Debug.Log("Servable");
            menudoTakeOut.tag = "ReadyToServe";
        }
    }
}