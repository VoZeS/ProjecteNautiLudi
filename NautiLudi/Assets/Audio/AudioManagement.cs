using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManagement : MonoBehaviour
{
    // Audio GO
    public AudioSource musicSource;
    public AudioSource fxSource;

    // UI GO
    public Image volumeImage;
    public Image fxImage;

    // Music Image GO
    public Sprite mutedMusicImage;
    public Sprite unmutedMusicImage;

    public void MusicMuteLogic()
    {
        musicSource.mute = !musicSource.mute;

        if (musicSource.mute == true)
        {
            if (mutedMusicImage != null && volumeImage != null)
            {
                volumeImage.sprite = mutedMusicImage;
            }
        }
        else if (musicSource.mute == false)
        {
            if (unmutedMusicImage != null && volumeImage != null)
            {
                volumeImage.sprite = unmutedMusicImage;
            }
        }
    }

    public void FXMuteLogic()
    {
        fxSource.mute = !fxSource.mute;

        if (fxSource.mute == true)
        {
            if (mutedMusicImage != null && fxImage != null)
            {
                fxImage.sprite = mutedMusicImage;
            }
        }
        else if (fxSource.mute == false)
        {
            if (unmutedMusicImage != null && fxImage != null)
            {
                fxImage.sprite = unmutedMusicImage;
            }
        }
    }
}
