using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullCollision : MonoBehaviour
{
    // Reference to the empty game object on top of the pillar
    public GameObject emptyGameObject;

    // References to the three operate objects
    public GameObject operateObject1;
    public GameObject operateObject2;
    public GameObject operateObject3;

    // Function called when collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is the empty game object on top of the pillar
        if (collision.gameObject == emptyGameObject)
        {
            // Set the three operate objects back to active
            operateObject1.SetActive(true);
            operateObject2.SetActive(true);
            operateObject3.SetActive(true);
        }
    }
}