using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomInterests : MonoBehaviour
{
    // SLIDERS
    [Header("Interests")]
    static public int socialInterestSlider;
    static public int sportsInterestSlider;
    static public int internationalInterestSlider;

    [Header("Social")]
    public Image lowSocialInterest;
    public Image midSocialInterest;
    public Image highSocialInterest;

    [Header("Sports")]
    public Image lowSportsInterest;
    public Image midSportsInterest;
    public Image highSportsInterest;

    [Header("International")]
    public Image lowInterInterest;
    public Image midInterInterest;
    public Image highInterInterest;

    [Header("Days")]
    static public int dayCount = 1;
    public TMP_Text dayText;

    private void Start()
    {
        RandInterests();

        dayCount = 1;
    }

    private void Update()
    {
        dayText.text = dayCount.ToString();
    }

    public void SetNewDay()
    {
        dayCount++;
        RandInterests();

    }

    public void RandInterests()
    {

        socialInterestSlider = Random.Range(1, 4);
        sportsInterestSlider = Random.Range(1, 4);
        internationalInterestSlider = Random.Range(1, 4);

        switch(socialInterestSlider)
        {
            case 1:
                lowSocialInterest.color = new Color(240f / 255f, 80f / 255f, 70f / 255f, 1); // RED
                midSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                highSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
            case 2:
                lowSocialInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                midSocialInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                highSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
            case 3:
                lowSocialInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                midSocialInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                highSocialInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                break;
            default:
                lowSocialInterest.color = new Color(1, 1, 1, 1); // WHITE
                midSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                highSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
        }

        switch (sportsInterestSlider)
        {
            case 1:
                lowSportsInterest.color = new Color(240f / 255f, 80f / 255f, 70f / 255f, 1); // RED
                midSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                highSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
            case 2:
                lowSportsInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                midSportsInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                highSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
            case 3:
                lowSportsInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                midSportsInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                highSportsInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                break;
            default:
                lowSportsInterest.color = new Color(1, 1, 1, 1); // WHITE
                midSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                highSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
        }

        switch (internationalInterestSlider)
        {
            case 1:
                lowInterInterest.color = new Color(240f / 255f, 80f / 255f, 70f / 255f, 1); // RED
                midInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                highInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
            case 2:
                lowInterInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                midInterInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                highInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
            case 3:
                lowInterInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                midInterInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                highInterInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                break;
            default:
                lowInterInterest.color = new Color(1, 1, 1, 1); // WHITE
                midInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                highInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                break;
        }
    }
}
