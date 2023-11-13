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

        
        referenceLinkButton.onClick.AddListener(() => OpenLink(news.url));
    }

    public void GetNewsData(News news)
    {
        socialValue = news.socialValue;
        sportsValue = news.sportsValue;
        internationalValue = news.internationalValue;
        moneyCost = news.moneyCost;
        isBlocked = news.isBlocked;
    }

    private void OpenLink(string link)
    {
        // Abrir el enlace en un navegador web
        Application.OpenURL(link);
    }
}