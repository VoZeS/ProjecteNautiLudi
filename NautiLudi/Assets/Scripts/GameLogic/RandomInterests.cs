using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomInterests : MonoBehaviour
{
    public GameManagement managerScript;
    public DisplayAllNews displayScript;


    // SLIDERS
    [Header("Interests")]
    static public int socialInterestSlider;
    static public int sportsInterestSlider;
    static public int internationalInterestSlider;   
    [Space(10)]
    static public int PC_socialInterestSlider;
    static public int PC_sportsInterestSlider;
    static public int PC_internationalInterestSlider;

    [Header("Social")]
    public Image lowSocialInterest;
    public Image midSocialInterest;
    public Image highSocialInterest;
    [Space(10)]
    public Image PC_lowSocialInterest;
    public Image PC_midSocialInterest;
    public Image PC_highSocialInterest;

    [Header("Sports")]
    public Image lowSportsInterest;
    public Image midSportsInterest;
    public Image highSportsInterest;
    [Space(10)]
    public Image PC_lowSportsInterest;
    public Image PC_midSportsInterest;
    public Image PC_highSportsInterest;

    [Header("International")]
    public Image lowInterInterest;
    public Image midInterInterest;
    public Image highInterInterest;
    [Space(10)]
    public Image PC_lowInterInterest;
    public Image PC_midInterInterest;
    public Image PC_highInterInterest;

    [Header("Days")]
    static public int dayCount;
    public TMP_Text dayText;
    public TMP_Text dayLoseText; 
    [Space(10)]
    public TMP_Text PC_dayText;
    public TMP_Text PC_dayLoseText;

    private void Start()
    {

        GameObject gameManager = GameObject.Find("GameManager");
        if (gameManager != null)
        {
            managerScript = gameManager.GetComponent<GameManagement>();
            if (managerScript == null)
            {
                Debug.Log("El GameObject optionsGroup no tiene el componente GameManagement adjunto.");
            }
        }
        else
        {
            Debug.Log("El GameObject gameManager no se ha encontrado en la escena. Asegúrate de que está presente y tiene el nombre 'GameManager'.");
        }
       

        RandInterests();

        //dayCount = 1;
    }

    private void Update()
    {
        if(UIDisplay.isPC)
        {
            PC_dayText.text = dayCount.ToString();
            PC_dayLoseText.text = dayCount.ToString();
        }
        else
        {
            dayText.text = dayCount.ToString();
            dayLoseText.text = dayCount.ToString();
        }
        
    }

    public void SetNewDay()
    {
        dayCount++;
        RandInterests();
        displayScript.AssignRandomNews();

        if (managerScript != null)
            managerScript.SaveGame();
    }

    public void RandInterests()
    {
        int rnd_social, rnd_sports, rnd_inter;

        rnd_social = Random.Range(1, 4);
        rnd_sports = Random.Range(1, 4);
        rnd_inter = Random.Range(1, 4);

        socialInterestSlider = rnd_social;
        PC_socialInterestSlider = rnd_social;

        sportsInterestSlider = rnd_sports;
        PC_sportsInterestSlider = rnd_sports;

        internationalInterestSlider = rnd_inter;
        PC_internationalInterestSlider = rnd_inter;

        if(UIDisplay.isPC)
        {
            switch (PC_socialInterestSlider)
            {
                case 1:
                    PC_lowSocialInterest.color = new Color(240f / 255f, 80f / 255f, 70f / 255f, 1); // RED
                    PC_midSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                    PC_highSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
                case 2:
                    PC_lowSocialInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                    PC_midSocialInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                    PC_highSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
                case 3:
                    PC_lowSocialInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_midSocialInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_highSocialInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    break;
                default:
                    PC_lowSocialInterest.color = new Color(1, 1, 1, 1); // WHITE
                    PC_midSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                    PC_highSocialInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
            }

            switch (PC_sportsInterestSlider)
            {
                case 1:
                    PC_lowSportsInterest.color = new Color(240f / 255f, 80f / 255f, 70f / 255f, 1); // RED
                    PC_midSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                    PC_highSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
                case 2:
                    PC_lowSportsInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                    PC_midSportsInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                    PC_highSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
                case 3:
                    PC_lowSportsInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_midSportsInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_highSportsInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    break;
                default:
                    PC_lowSportsInterest.color = new Color(1, 1, 1, 1); // WHITE
                    PC_midSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                    PC_highSportsInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
            }

            switch (PC_internationalInterestSlider)
            {
                case 1:
                    PC_lowInterInterest.color = new Color(240f / 255f, 80f / 255f, 70f / 255f, 1); // RED
                    PC_midInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                    PC_highInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
                case 2:
                    PC_lowInterInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                    PC_midInterInterest.color = new Color(240f / 255f, 180f / 255f, 70f / 255f, 1); // YELLOW
                    PC_highInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
                case 3:
                    PC_lowInterInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_midInterInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_highInterInterest.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    break;
                default:
                    PC_lowInterInterest.color = new Color(1, 1, 1, 1); // WHITE
                    PC_midInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                    PC_highInterInterest.color = new Color(1, 1, 1, 1); //WHITE
                    break;
            }
        }
        else
        {
            switch (socialInterestSlider)
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
}
