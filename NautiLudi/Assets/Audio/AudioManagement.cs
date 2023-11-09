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
    public Image fxImage;

    // Music Image GO
    public Sprite mutedMusicImage;
    public Sprite unmutedMusicImage;

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
        if (isFxOn)
        {
            audioMixer.SetFloat("VolFX", lastVolumeFX);
            fxImage.sprite = unmutedMusicImage;
        }
        else if (!isFxOn)
        {
            audioMixer.GetFloat("VolFX", out lastVolumeFX);
            audioMixer.SetFloat("VolFX", -80);
            fxImage.sprite = mutedMusicImage;
        }
    }

    private void GetMusicVolume()
    {
        if (isMusicOn)
        {
            audioMixer.SetFloat("VolMusic", lastVolumeMusic);
            volumeImage.sprite = unmutedMusicImage;
        }
        else if (!isMusicOn)
        {
            audioMixer.GetFloat("VolMusic", out lastVolumeMusic);
            audioMixer.SetFloat("VolMusic", -80);
            volumeImage.sprite = mutedMusicImage;
        }
    }

    public void SetMusicMute()
    {

        if (isMusicOn)
        {
            audioMixer.GetFloat("VolMusic", out lastVolumeMusic);
            audioMixer.SetFloat("VolMusic", -80);
            volumeImage.sprite = mutedMusicImage;
            isMusicOn = false;
        }
        else if(!isMusicOn)
        {
            audioMixer.SetFloat("VolMusic", lastVolumeMusic);
            volumeImage.sprite = unmutedMusicImage;
            isMusicOn = true;
        }
    }

    public void SetFXMute()
    {

        if (isFxOn)
        {
            audioMixer.GetFloat("VolFX", out lastVolumeFX);
            audioMixer.SetFloat("VolFX", -80);
            fxImage.sprite = mutedMusicImage;
            isFxOn = false;
        }
        else if (!isFxOn)
        {
            audioMixer.SetFloat("VolFX", lastVolumeFX);
            fxImage.sprite = unmutedMusicImage;
            isFxOn = true;
        }
    }
}
