using UnityEngine;

public class MoveThingsScript : MonoBehaviour
{
    public int occupiedSlot = 98;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        occupiedSlot = GMObjScript.selectedSlot;
    }

    // Update is called once per frame
    void Update()
    {
        if (occupiedSlot == GMObjScript.selectedDish)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
    }
}
