using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomInterests : MonoBehaviour
{
    // SLIDERS
    [Header("Interests")]
    public Slider socialInterestSlider;
    public Slider sportsInterestSlider;
    public Slider internationalInterestSlider;

    [Header("Days")]
    public int dayCount = 1;
    public TMP_Text dayText;

    private void Start()
    {
        // Initial values
        //socialInterestSlider.value = 0.5f;
        //sportsInterestSlider.value = 0.5f;
        //internationalInterestSlider.value = 0.5f;

        dayCount = 1;
    }

    private void Update()
    {
        dayText.text = "" + dayCount;
    }

    public void RandInterests()
    {
        socialInterestSlider.value = Random.Range(0.0f, 1.0f);
        sportsInterestSlider.value = Random.Range(0.0f, 1.0f);
        internationalInterestSlider.value = Random.Range(0.0f, 1.0f);

    }
}
