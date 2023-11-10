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
        //AdjustButtonsSize();

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
        float targetAspect = targetWidth / targetHeight;
        float currentAspect = currentWidth / currentHeight;

        if (Mathf.Abs(targetAspect - currentAspect) < aspectRatioThreshold)
        {
            //mainCamera.orthographicSize = baseDesktopSize;

            if (camMovScript.end)
            {
                //camMovScript.timer += Time.deltaTime;
                //float t = Mathf.Clamp01(camMovScript.timer / camMovScript.zoomDuration);

                //camMovScript.cam.orthographicSize = Mathf.Lerp(baseDesktopSize, baseDesktopSize - 30f, t);

                camMovScript.SetCamSize(baseDesktopSize);

            }
            else
            {
                camMovScript.SetCamSize(baseDesktopSize);

            }
        }
        else
        {
            //float baseSize = (currentWidth < currentHeight) ? baseMobileSize : baseDesktopSize;
            //float newSize = baseSize * (targetAspect / currentAspect);
            //mainCamera.orthographicSize = baseMobileSize;

            if (camMovScript.end)
            {
                camMovScript.timer += Time.deltaTime;
                float t = Mathf.Clamp01(camMovScript.timer / camMovScript.zoomDuration);

                camMovScript.cam.orthographicSize = Mathf.Lerp(baseMobileSize, baseMobileSize - 30f, t);
            }
            else
            {
                camMovScript.SetCamSize(baseMobileSize);

            }
        }
    }

    void AdjustButtonsSize()
    {
        //float widthRatio = currentWidth / targetWidth;
        //float heightRatio = currentHeight / targetHeight;

        // Buttons config
        //buttonRectTransform.anchoredPosition += new Vector2(positionOffset.x * widthRatio, positionOffset.y * heightRatio);
        //buttonRectTransform.sizeDelta += new Vector2(sizeOffset.x * widthRatio, sizeOffset.y * heightRatio);
    }
}
