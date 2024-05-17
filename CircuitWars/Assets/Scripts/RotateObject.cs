using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Set the rotation speed in degrees per second
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the Z-axis based on the rotation speed and the time elapsed since the last frame
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}

