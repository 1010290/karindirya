using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RestaurantCameraFollowScript : MonoBehaviour
{
    //How Fast Camera Follows Object:
    public float FollowSpeed = 10f;
    //Variable to Give Object's Position
    public Transform targetObject;

    void Update()
    {
        Vector3 newPosition = new Vector3(targetObject.position.x, targetObject.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed * Time.deltaTime);
    }
}
