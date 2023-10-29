using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManagement : MonoBehaviour
{
    // Audio GO
    private AudioSource musicSource;
    private AudioSource fxSource;

    // UI GO
    public Image volumeImage;
    public Image fxImage;

    // Music Image GO
    public Sprite mutedMusicImage;
    public Sprite unmutedMusicImage;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        musicSource = GameObject.Find("MusicManager").GetComponent<AudioSource>();
        fxSource = GameObject.Find("FXManager").GetComponent<AudioSource>();

        //volumeImage = GameObject.Find("MuteVolumeButton").GetComponent<Image>();
        //fxImage = GameObject.Find("MuteFXButton").GetComponent<Image>();
    }

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
