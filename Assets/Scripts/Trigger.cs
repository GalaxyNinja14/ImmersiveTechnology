using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Trigger : MonoBehaviour
{
    public GameObject prefabToSpawn; // Assign your prefab in the inspector

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is a ball
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Instantiate the prefab at the position of the empty game object
            GameObject spawnedObject = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);

            // Add Sphere Collider
            SphereCollider collider = spawnedObject.AddComponent<SphereCollider>();

            // Add Rigidbody
            Rigidbody rb = spawnedObject.AddComponent<Rigidbody>();

            // Add XR Grab Interactable
            XRGrabInteractable grabInteractable = spawnedObject.AddComponent<XRGrabInteractable>();

            // Set tag
            spawnedObject.tag = "cradleObject";
        }
    }
}

