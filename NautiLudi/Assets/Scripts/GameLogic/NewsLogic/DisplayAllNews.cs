using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAllNews : MonoBehaviour
{
    private News news;

    [Header("Selection Panel")]
    public TMP_Text titleNews;
    public TMP_Text shortDescription;

    [Header("Info Panel")]
    public TMP_Text titleInfo;
    public TMP_Text extendedDescription;
    public Image infoImage;

    private void Start()
    {
        news = GetComponent<News>();
    }

    private void Update()
    {
        titleNews.text = news.title;
        titleInfo.text = news.title;
        //titleNewspaper.text = news.title;

        shortDescription.text = news.shortDescription;
        extendedDescription.text = news.extendedDescription;
        //shortNewspaperDescription.text = news.shortDescription;

        infoImage.sprite = news.newsImage;
        //newspaperImage.sprite = news.newsImage;

    }
}
