using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManagement : MonoBehaviour
{
    // Audio GO
    public AudioMixer audioMixer;
    public float lastVolumeFX;
    public float lastVolumeMusic;

    // UI GO
    public Toggle muteFX;
    public Toggle muteMusic;
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
        //musicGroup = GameObject.Find("MusicManager").GetComponent<AudioSource>();
        //fxGroup = GameObject.Find("FXManager").GetComponent<AudioSource>();

        //volumeImage = GameObject.Find("MuteVolumeButton").GetComponent<Image>();
        //fxImage = GameObject.Find("MuteFXButton").GetComponent<Image>();
    }

    public void SetMusicMute()
    {

        if (muteMusic.isOn)
        {
            audioMixer.GetFloat("VolMusic", out lastVolumeMusic);
            audioMixer.SetFloat("VolMusic", -80);
            volumeImage.sprite = mutedMusicImage;
        }
        else
        {
            audioMixer.SetFloat("VolMusic", lastVolumeMusic);
            volumeImage.sprite = unmutedMusicImage;
        }
    }

    public void SetFXMute()
    {

        if (muteFX.isOn)
        {
            audioMixer.GetFloat("VolFX", out lastVolumeFX);
            audioMixer.SetFloat("VolFX", -80);
            fxImage.sprite = mutedMusicImage;

        }
        else
        {
            audioMixer.SetFloat("VolFX", lastVolumeFX);
            fxImage.sprite = unmutedMusicImage;
        }
    }
}
