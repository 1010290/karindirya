using UnityEngine;

public class CustomerScript : MonoBehaviour
{
    //TO TRACK WHAT THE CUSTOMER ORDERED
    public string customerOrder = "menudoTakeOut";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        Debug.Log("COLLIDE");
        /*
        if (gameObject.tag == "ReadyToServe" && gameObject.name == customerOrder)
        {
            Debug.Log("CORRECT ORDER");
        }
        */
    }
}
