using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Camera mainCamera;
    Renderer[] renderers;
    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
    }
    bool CheckRenderers()
    {
        foreach (var renderer in renderers)
        {
            // If at least one render is visible, return true 
            if (renderer.isVisible)
            {
                return true;
            }
        }
        // Otherwise, the object is invisible 
        return false;
    }
    void Update()
    {
        var viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        var newPosition = transform.position;
        if (viewportPosition.x > 1 || viewportPosition.x < 0)
        {
            newPosition.y = -newPosition.y;
        }
        if (viewportPosition.y > 1 || viewportPosition.y < 0)
        {
            newPosition.y = -newPosition.y;
        }
        transform.position = newPosition;
    }
}
