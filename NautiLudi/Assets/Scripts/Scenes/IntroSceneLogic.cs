using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class IntroSceneLogic : MonoBehaviour
{
    private ChangeScene sceneManager;
    public BlackSmooth fadeMan;
    public Image foreground;

    private float timer;
    private bool startFade = false;

    private void Start()
    {
        sceneManager = GetComponent<ChangeScene>();

        timer = 0f;
        startFade = false;

        fadeMan.Image_StartToInvisibleFading(foreground);
    }
   
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2.0f && !startFade)
        {
            fadeMan.Image_StartToVisibleFading(foreground);
            startFade = true;
        }

    }
}
