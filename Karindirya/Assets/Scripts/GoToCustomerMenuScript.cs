using UnityEngine;

public class GoToCustomerMenuScript : MonoBehaviour
{
    public GameObject objectToMove;
    void OnMouseDown()
    {
        objectToMove.transform.position = new Vector2(-16.81f, 0f);
    }
}
