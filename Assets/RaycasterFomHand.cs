using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycasterFomHand : MonoBehaviour
{
    // The maximum distance the ray will cast
    public float rayDistance = 100f;
    public NavMeshController controller;
    private LineRenderer lineRenderer;

    void Start()
    {
        // Add LineRenderer to the object if it doesn't already have one
        lineRenderer = gameObject.AddComponent<LineRenderer>();
    }
        // Update is called once per frame
    public void CastRay()
    {
        // The ray starts at the object's position and goes in the forward direction
        Ray ray = new Ray(transform.position, transform.forward);

        // To store the hit information
        RaycastHit hit;

        // Cast the ray and check if it hits something
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            // If the ray hits an object, output the name of the object
            Debug.Log("Ray hit: " + hit.collider.name);

            // Optionally, visualize the ray in the Scene view
            Debug.DrawLine(ray.origin, hit.point, Color.red, 2f);
            
            controller.SetDestination(hit.point);

        }

    }
}
