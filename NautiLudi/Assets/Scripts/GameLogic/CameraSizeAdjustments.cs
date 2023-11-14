using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSizeAdjustments : MonoBehaviour
{
    public CameraMovement camMovScript;

    private float currentWidth;
    private float currentHeight;

    [Header("Camera")]
    private Camera mainCamera;
    public float aspectRatioThreshold = 0.1f;
    private float targetWidth = 1920f;
    private float targetHeight = 1080f;
    public float baseMobileSize = 50f;
    public float baseDesktopSize = 13f;

    [Header("Buttons")]
    public RectTransform buttonRectTransform;
    public Vector2 positionOffset;
    public Vector2 sizeOffset;

    void Start()
    {
        mainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();

        UpdateScreenSize();
        AdjustCameraSize();

    }


    private void Update()
    {
        UpdateScreenSize();
        AdjustCameraSize();

    }
    void UpdateScreenSize()
    {
        currentWidth = Screen.width;
        currentHeight = Screen.height;
    }

    void AdjustCameraSize()
    {
        if (UIDisplay.isPC)
        {
            camMovScript.SetCamSize(baseDesktopSize);

        }
        else
        {
            if (camMovScript.end)
            {
                camMovScript.timer += Time.deltaTime;
                float t = Mathf.Clamp01(camMovScript.timer / camMovScript.zoomDuration);

                camMovScript.cam.orthographicSize = Mathf.Lerp(baseMobileSize, baseMobileSize - 35f, t);
            }
            else
            {
                camMovScript.SetCamSize(baseMobileSize);

            }
        }
    }
}
