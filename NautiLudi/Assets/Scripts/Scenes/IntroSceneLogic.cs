using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IntroSceneLogic : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private ChangeScene sceneManager;

    private void Start()
    {
        sceneManager = GetComponent<ChangeScene>();
    }
   
    void Update()
    {
        if(videoPlayer.isPaused)
        {
            sceneManager.GoToScene("MainMenuScene");
        }
    }
}
