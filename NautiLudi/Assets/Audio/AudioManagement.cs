using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;

public class AudioManagement : MonoBehaviour
{
    // Audio GO
    public AudioMixer audioMixer;
    static public float lastVolumeFX;
    static public float lastVolumeMusic;

    // UI GO
    public Toggle muteFX;
    static public bool isFxOn;
    public Toggle muteMusic;
    static public bool isMusicOn;
    public Image volumeImage;
    public Image volumeMainMenuImage;
    public Image fxImage;
    public Image fxMainMenuImage;

    // Between Scenes Logic
    private static bool audioCreated = false;

    private void Awake()
    {
        if (!audioCreated)
        {
            DontDestroyOnLoad(this.gameObject);
            audioCreated = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        GetMusicVolume();
        GetFxVolume();
    }
    private void GetFxVolume()
    {
        if (isFxOn) // IS ON
        {
            audioMixer.SetFloat("VolFX", lastVolumeFX);
            fxMainMenuImage.color = new Color(1, 1, 1, 1); // WHITE
            fxImage.color = new Color(1, 1, 1, 1); // WHITE
        }
        else if (!isFxOn) // IS MUTED
        {
            audioMixer.GetFloat("VolFX", out lastVolumeFX);
            audioMixer.SetFloat("VolFX", -80);
            fxMainMenuImage.color = new Color(118 / 255f, 118 / 255f, 118 / 255f, 1); // GREY
            fxImage.color = new Color(118 / 255f, 118 / 255f, 118 / 255f, 1); // GREY

        }
    }

    private void GetMusicVolume()
    {
        if (isMusicOn) // IS ON
        {
            audioMixer.SetFloat("VolMusic", lastVolumeMusic);
            volumeMainMenuImage.color = new Color(1, 1, 1, 1); // WHITE
            volumeImage.color = new Color(1, 1, 1, 1); // WHITE
        }
        else if (!isMusicOn) // IS MUTED
        {
            audioMixer.GetFloat("VolMusic", out lastVolumeMusic);
            audioMixer.SetFloat("VolMusic", -80);
            volumeMainMenuImage.color = new Color(118 / 255f, 118 / 255f, 118 / 255f, 1); // GREY
            volumeImage.color = new Color(118 / 255f, 118 / 255f, 118 / 255f, 1); // GREY
        }
    }

    public void SetMusicMute()
    {

        if (isMusicOn) // MUTE
        {
            audioMixer.GetFloat("VolMusic", out lastVolumeMusic);
            audioMixer.SetFloat("VolMusic", -80);
            volumeMainMenuImage.color = new Color(118 / 255f, 118 / 255f, 118 / 255f, 1); // GREY
            volumeImage.color = new Color(118 / 255f, 118 / 255f, 118 / 255f, 1); // GREY

            isMusicOn = false;
        }
        else if(!isMusicOn) // UNMUTE
        {
            audioMixer.SetFloat("VolMusic", lastVolumeMusic);
            volumeMainMenuImage.color = new Color(1, 1, 1, 1); // WHITE
            volumeImage.color = new Color(1, 1, 1, 1); // WHITE

            isMusicOn = true;
        }
    }

    public void SetFXMute()
    {

        if (isFxOn) // MUTE
        {
            audioMixer.GetFloat("VolFX", out lastVolumeFX);
            audioMixer.SetFloat("VolFX", -80);
            fxMainMenuImage.color = new Color(118 / 255f, 118 / 255f, 118 / 255f, 1); // GREY
            fxImage.color = new Color(118 / 255f, 118 / 255f, 118 / 255f, 1); // GREY

            isFxOn = false;
        }
        else if (!isFxOn) // UNMUTE
        {
            audioMixer.SetFloat("VolFX", lastVolumeFX);
            fxMainMenuImage.color = new Color(1, 1, 1, 1); // WHITE
            fxImage.color = new Color(1, 1, 1, 1); // WHITE

            isFxOn = true;
        }
    }
}
