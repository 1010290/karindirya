using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishControlButtonScript : MonoBehaviour
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
    public void InstantiateDish()
    {
        Instantiate(tinolaObj, new Vector2(-429.3f, -233.81f), tinolaObj.rotation);
        Debug.Log("tinolaObj Pressed");
        Debug.Log("ButtonPressed"); //ONLY FOR CHECKING PURPOSES
    }
}
