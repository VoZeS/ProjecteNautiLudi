using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisplay : MonoBehaviour
{
    private float currentWidth;
    private float currentHeight;

    private float targetWidth = 1920f;
    private float targetHeight = 1080f;

    private float aspectRatioThreshold = 0.1f;

    public GameObject UI_PC;
    public GameObject UI_Mobile;

    static public bool isPC;

    // Start is called before the first frame update
    void Awake()
    {
        UpdateScreenSize();
        GetUIType();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScreenSize();
        GetUIType();
    }

    void UpdateScreenSize()
    {
        currentWidth = Screen.width;
        currentHeight = Screen.height;
    }

    public void GetUIType()
    {
        float targetAspect = targetWidth / targetHeight;
        float currentAspect = currentWidth / currentHeight;

        if (Mathf.Abs(targetAspect - currentAspect) < aspectRatioThreshold)
        {
            isPC = true;

            UI_PC.SetActive(true);
            UI_Mobile.SetActive(false);
        }
        else
        {
            isPC = false;

            UI_PC.SetActive(false);
            UI_Mobile.SetActive(true);
        }

    }
}
