using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform target; 
    public float smoothSpeed = 5.0f;
    public float rotationSpeed = 45.0f;

    private bool isMoving = false;

    void LateUpdate()
    {
        if (isMoving)
        {
            Vector3 desiredPosition = target.position;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); 

            transform.position = smoothedPosition;

            Quaternion desiredRotation = target.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);

        }
    }

    public void MoveCamera(Transform targetFinal)
    {
        isMoving = true;
        target = targetFinal;
    }
}
