using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsObject : MonoBehaviour
{
    public TMP_Text titleText;
    public TMP_Text titleInfoText;
    public TMP_Text shortDescriptionText;
    public TMP_Text longDescriptionText;
    public Image newsImage;
    public Button referenceLinkButton;
    public TMP_Text newsCost;

    public void DisplayNews(News news)
    {
        
        titleText.text = news.title;
        titleInfoText.text = news.title;
        shortDescriptionText.text = news.shortDescription;
        longDescriptionText.text = news.extendedDescription;
        newsCost.text = news.moneyCost.ToString();


        newsImage.sprite = Resources.Load<Sprite>(news.newsImage);

        
        referenceLinkButton.onClick.AddListener(() => OpenLink(news.url));
    }

    private void OpenLink(string link)
    {
        // Abrir el enlace en un navegador web
        Application.OpenURL(link);
    }
}