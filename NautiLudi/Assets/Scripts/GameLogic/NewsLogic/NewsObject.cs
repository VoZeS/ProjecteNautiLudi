using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsObject : MonoBehaviour
{
    [Header("Visual")]
    public TMP_Text titleText;
    public TMP_Text shortDescriptionText;
    public TMP_Text newsCost;
    [Space(10)]
    public TMP_Text titleInfoText;
    public TMP_Text longDescriptionText;
    public Image newImage;
    public Button referenceLinkButton;
    [Space(10)]
    public Image lowSocialInterest;
    public Image midSocialInterest;
    public Image highSocialInterest;
    [Space(10)]
    public Image lowSportsInterest;
    public Image midSportsInterest;
    public Image highSportsInterest;
    [Space(10)]
    public Image lowInterInterest;
    public Image midInterInterest;
    public Image highInterInterest;

    [Header("Logic")]
    public int socialValue;
    public int sportsValue;
    public int internationalValue;
    public int moneyCost;
    public bool isBlocked = true;

    public void DisplayNews(News news)
    {
        
        titleText.text = news.title;
        titleInfoText.text = news.title;
        shortDescriptionText.text = news.shortDescription;
        longDescriptionText.text = news.extendedDescription;
        newsCost.text = news.moneyCost.ToString();

        Sprite loadedSprite = Resources.Load<Sprite>(news.newsImage);

        if (loadedSprite != null)
        {
            Debug.Log("Sprite cargado correctamente");
            newImage.sprite = loadedSprite;
        }
        else
        {
            Debug.LogError("No se pudo cargar el sprite desde la ruta: " + news.newsImage);
        }

        referenceLinkButton.onClick.RemoveAllListeners();
        referenceLinkButton.onClick.AddListener(() => OpenLink(news.url));
    }

    public void GetNewsData(News news)
    {
        socialValue = news.socialValue;
        sportsValue = news.sportsValue;
        internationalValue = news.internationalValue;
        moneyCost = news.moneyCost;
        isBlocked = news.isBlocked;

        DisplayValues();
    }

    private void DisplayValues()
    {
        switch (socialValue)
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

        switch (sportsValue)
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

        switch (internationalValue)
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

    private void OpenLink(string link)
    {
        // Abrir el enlace en un navegador web
        Application.OpenURL(link);
    }
}