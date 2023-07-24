using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarRotation : MonoBehaviour
{
    public Transform cameraTransform; // Reference to the camera's transform
    public float minRotationThreshold = 10f; // Minimum rotation threshold in degrees

    private void Update()
    {
        // Get the rotation of the camera around the y-axis
        float cameraRotation = cameraTransform.rotation.eulerAngles.y;

        // Calculate the difference in rotation between the avatar and the camera
        float rotationDifference = Mathf.Abs(transform.rotation.eulerAngles.y - cameraRotation);

        // Check if the rotation difference is greater than the minimum rotation threshold
        if (rotationDifference > minRotationThreshold)
        {
            // Set the avatar's rotation to match the camera's rotation around the y-axis
            transform.rotation = Quaternion.Euler(0f, cameraRotation, 0f);
        }
    }
}
