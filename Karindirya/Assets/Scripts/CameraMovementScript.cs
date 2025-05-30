using UnityEngine;

public class GoToCustomerMenuScript : MonoBehaviour
{
    public GameObject objectToMove;
    
    void OnMouseDown()
    {
        if (gameObject.name == "BacktoCashRegisterButton")
        {
            objectToMove.transform.position = new Vector2(-16.81f, 0f);
        }
        if (gameObject.name == "GoToDishesMenuButton")
        {
            objectToMove.transform.position = new Vector2(1, 0);
        }
    }
}

