using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    // Speed at which the game object will move towards the cursor
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        // Get the position of the player's cursor in world space
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = 0f; // Make sure the z-coordinate is 0 (or whatever you want)

        // Calculate the direction from the current position to the target position
        Vector3 direction = targetPosition - transform.position;

        // Calculate the distance from the current position to the target position
        float distance = direction.magnitude;

        // Normalize the direction so that it has a length of 1
        direction.Normalize();

        // If the distance is greater than 0, move towards the target position
        if (distance > 0)
        {
            // Calculate the amount to move based on the speed and the time since the last frame
            float amountToMove = speed * Time.deltaTime;

            // If the amount to move is greater than the distance to the target position, set the position to the target position
            if (amountToMove > distance)
            {
                transform.position = targetPosition;
            }
            // Otherwise, move towards the target position
            else
            {
                transform.position += direction * amountToMove;
            }
        }
    }
}

