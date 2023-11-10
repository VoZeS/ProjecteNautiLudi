using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera cam;
    private Transform target; 
    public float smoothSpeed = 5.0f;
    public float rotationSpeed = 45.0f;

    private bool isMoving = false;
    public bool end = false;

    public float timer = 0.0f;

    public float zoomDuration = 50.0f;

    private void Start()
    {
        cam = GetComponent<Camera>();
        end = false;
    }
    void LateUpdate()
    {
        if (isMoving)
        {
            Vector3 desiredPosition = target.position;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); 

            transform.position = smoothedPosition;

            Quaternion desiredRotation = target.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);

            if(target.position == transform.position)
            {
                isMoving = false;
            }
        }

    }

    public void MoveCamera(Transform targetFinal)
    {
        isMoving = true;
        target = targetFinal;
    }

    public void SetEnd(bool hasFinished)
    {
        end = hasFinished;
    }

    public void SetCamSize(float size)
    {
        cam.orthographicSize = size;
    }
}
