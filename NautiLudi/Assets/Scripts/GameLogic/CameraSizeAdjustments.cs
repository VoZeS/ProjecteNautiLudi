using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizeAdjustments : MonoBehaviour
{
    private Camera mainCamera;
    public float baseSize = 13f;
    public float targetWidth = 828f;
    public float targetHeight = 1792f;
    public float targetSize = 50f;

    void Start()
    {
        mainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();

    }

    private void Update()
    {
        AdjustCameraSize();

    }

    void AdjustCameraSize()
    {
        float targetAspect = targetWidth / targetHeight;
        float currentAspect = (float)Screen.width / Screen.height;

        if (Mathf.Approximately(targetAspect, currentAspect))
        {
            mainCamera.orthographicSize = baseSize;
        }
        else
        {
            float newSize = baseSize * (targetAspect / currentAspect) * (targetSize / baseSize);
            mainCamera.orthographicSize = newSize;
        }
    }
}
