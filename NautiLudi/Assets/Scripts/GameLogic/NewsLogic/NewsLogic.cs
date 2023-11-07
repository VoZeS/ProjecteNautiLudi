using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsLogic : MonoBehaviour
{
    [Header("General Panel")]
    public TMP_Text newsSelectedText;

    [Header("Info Panel")]
    public TMP_Text[] infoNewsSelectedText;

    static public double selectedNews;

    static public List<News> newsSelectedList = new List<News>();

    [Header("Newspaper Panel")]
    public TMP_Text[] titleNewspaper;
    public TMP_Text[] shortNewspaperDescription;
    public Image[] newspaperImage;

    private void Start()
    {
        selectedNews = newsSelectedList.Count;

    }

    // Update is called once per frame
    void Update()
    {
        selectedNews = newsSelectedList.Count;

        // ------------- General Panel -------------
        newsSelectedText.text = selectedNews + "/3";

        // --------------- Info Panel --------------
        for (int i = 0; i < infoNewsSelectedText.Length; i++)
        {
            infoNewsSelectedText[i].text = selectedNews + "/3";
        }
        
        // --------------- News List Management --------------
        for (int i = 0; i < newsSelectedList.Count; i++)
        {
            newsSelectedList[i].isBlocked = false;
        }


    }

    public void DisplaySelectedNews()
    {
        for(int i = 0; i < newsSelectedList.Count; i++)
        {
            titleNewspaper[i].text = newsSelectedList[i].title;
            shortNewspaperDescription[i].text = newsSelectedList[i].shortDescription;
            newspaperImage[i].sprite = newsSelectedList[i].newsImage;
        }
    }
}
