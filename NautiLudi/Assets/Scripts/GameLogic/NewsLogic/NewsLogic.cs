using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsLogic : MonoBehaviour
{
    [Header("General Panel")]
    public TMP_Text newsSelectedText;
    public GameObject contentObject;
    public GameObject[] news;
    private RectTransform rectTransform;
    public Scrollbar scrollBar;

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

        rectTransform = contentObject.GetComponent<RectTransform>();
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

    public void SetFreeNews()
    {
        switch(UpgradesLogic.freeLevel)
        {
            case 1:
                news[0].GetComponent<News>().moneyCost = 0;
                break;
            case 2:
                news[0].GetComponent<News>().moneyCost = 0;
                news[1].GetComponent<News>().moneyCost = 0;
                break;
            default:
                break;
        }
    }

    public void SetQuantityNews()
    {
        switch (UpgradesLogic.quantityLevel)
        {
            case 0:
                UpgradesLogic.newsQuantity = 4;
                rectTransform.sizeDelta = new Vector2(750f, 2200f);
                scrollBar.value = 1;

                for (int i = 0; i < 4; i++)
                {
                    news[i].transform.position = new Vector3(news[i].transform.position.x, 750f - (400f * i), news[i].transform.position.z);
                }
                news[4].SetActive(false);
                news[5].SetActive(false);
                news[6].SetActive(false);

                break;
            case 1:
                UpgradesLogic.newsQuantity = 5;
                rectTransform.sizeDelta = new Vector2(750f, 2700f);
                scrollBar.value = 1;

                for (int i = 0; i < 5; i++)
                {
                    news[i].transform.position = new Vector3(news[i].transform.position.x, 750f - (400f * i), news[i].transform.position.z);
                }
                news[5].SetActive(false);
                news[6].SetActive(false);

                break;
            case 2:
                UpgradesLogic.newsQuantity = 6;
                rectTransform.sizeDelta = new Vector2(750f, 3200f);
                scrollBar.value = 1;

                for (int i = 0; i < 6; i++)
                {
                    news[i].transform.position = new Vector3(news[i].transform.position.x, 750f - (400f * i), news[i].transform.position.z);
                }
                news[6].SetActive(false);

                break;
            case 3:
                UpgradesLogic.newsQuantity = 7;
                rectTransform.sizeDelta = new Vector2(750f, 3700f);
                scrollBar.value = 1;

                for (int i = 0; i < 7; i++)
                {
                    news[i].transform.position = new Vector3(news[i].transform.position.x, 750f - (400f * i), news[i].transform.position.z);
                }

                break;
            default:
                rectTransform.sizeDelta = new Vector2(750f, 2200f);
                scrollBar.value = 1;

                for (int i = 0; i < 4; i++)
                {
                    news[i].transform.position = new Vector3(news[i].transform.position.x, 750f - (400f * i), news[i].transform.position.z);
                }

                break;
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
