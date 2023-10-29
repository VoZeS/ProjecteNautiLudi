using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomInterests : MonoBehaviour
{
    // SLIDERS
    public Slider socialInterestSlider;
    public Slider sportsInterestSlider;
    public Slider internationalInterestSlider;

    private void Start()
    {
        RandInterests();
    }

    public void RandInterests()
    {
        socialInterestSlider.value = Random.Range(0.0f, 1.0f);
        sportsInterestSlider.value = Random.Range(0.0f, 1.0f);
        internationalInterestSlider.value = Random.Range(0.0f, 1.0f);
    }
}
