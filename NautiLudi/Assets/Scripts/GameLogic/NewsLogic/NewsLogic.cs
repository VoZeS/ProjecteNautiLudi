using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsLogic : MonoBehaviour
{
    [Header("General Panel")]
    public TMP_Text newsSelectedText;
    public TMP_Text PC_newsSelectedText;
    public GameObject contentObject;
    public GameObject PC_contentObject;
    public GameObject[] news;
    public GameObject[] PC_news;
    private RectTransform rectTransform;
    public Scrollbar scrollBar;
    private RectTransform PC_rectTransform;
    public Scrollbar PC_scrollBar;

    [Header("Info Panel")]
    public TMP_Text[] infoNewsSelectedText;
    public TMP_Text[] PC_infoNewsSelectedText;

    static public double selectedNews;

    static public List<NewsObject> newsSelectedList = new List<NewsObject>();
    //static public List<NewsObject> newsObjectSelectedList = new List<NewsObject>();

    [Header("Newspaper Panel")]
    public TMP_Text companyName;
    public TMP_Text[] titleNewspaper;
    public TMP_Text[] shortNewspaperDescription;
    public Image[] newspaperImage;
    [Space(10)]
    public TMP_Text PC_companyName;
    public TMP_Text[] PC_titleNewspaper;
    public TMP_Text[] PC_shortNewspaperDescription;
    public Image[] PC_newspaperImage;

    private void Start()
    {
        selectedNews = newsSelectedList.Count;

        rectTransform = contentObject.GetComponent<RectTransform>();
        PC_rectTransform = PC_contentObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        selectedNews = newsSelectedList.Count;

        // ------------- General Panel -------------
        if(UIDisplay.isPC)
        {
            PC_newsSelectedText.text = selectedNews + "/3";

        }
        else
        {
            newsSelectedText.text = selectedNews + "/3";

        }

        // --------------- Info Panel --------------
        if (UIDisplay.isPC)
        {
            for (int i = 0; i < infoNewsSelectedText.Length; i++)
            {
                PC_infoNewsSelectedText[i].text = selectedNews + "/3";
            }
        }
        else
        {
            for (int i = 0; i < infoNewsSelectedText.Length; i++)
            {
                infoNewsSelectedText[i].text = selectedNews + "/3";
            }
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

                if(UIDisplay.isPC)
                {
                    PC_news[0].GetComponent<News>().moneyCost = 0;

                }
                else
                {
                    news[0].GetComponent<News>().moneyCost = 0;

                }

                break;
            case 2:

                if (UIDisplay.isPC)
                {
                    PC_news[0].GetComponent<News>().moneyCost = 0;
                    PC_news[1].GetComponent<News>().moneyCost = 0;
                }
                else
                {
                    news[0].GetComponent<News>().moneyCost = 0;
                    news[1].GetComponent<News>().moneyCost = 0;
                }
                    
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

                if(UIDisplay.isPC)
                {
                    UpgradesLogic.newsQuantity = 4;
                    PC_rectTransform.sizeDelta = new Vector2(750f, 2100f);
                    PC_scrollBar.value = 1;

                    for (int i = 0; i < 4; i++)
                    {
                        PC_news[i].SetActive(true);
                    }
                    PC_news[4].SetActive(false);
                    PC_news[5].SetActive(false);
                    PC_news[6].SetActive(false);
                }
                else
                {
                    UpgradesLogic.newsQuantity = 4;
                    rectTransform.sizeDelta = new Vector2(750f, 2200f);
                    scrollBar.value = 1;

                    for (int i = 0; i < 4; i++)
                    {
                        news[i].SetActive(true);

                    }
                    news[4].SetActive(false);
                    news[5].SetActive(false);
                    news[6].SetActive(false);
                }
                

                break;
            case 1:

                if (UIDisplay.isPC)
                {
                    UpgradesLogic.newsQuantity = 5;
                    PC_rectTransform.sizeDelta = new Vector2(750f, 2900f);
                    PC_scrollBar.value = 1;

                    for (int i = 0; i < 5; i++)
                    {
                        PC_news[i].SetActive(true);

                    }
                    PC_news[5].SetActive(false);
                    PC_news[6].SetActive(false);
                }
                else
                {
                    UpgradesLogic.newsQuantity = 5;
                    rectTransform.sizeDelta = new Vector2(750f, 3000f);
                    scrollBar.value = 1;

                    for (int i = 0; i < 5; i++)
                    {
                        news[i].SetActive(true);
                    }
                    news[5].SetActive(false);
                    news[6].SetActive(false);
                }
                   

                break;
            case 2:

                if (UIDisplay.isPC)
                {
                    UpgradesLogic.newsQuantity = 6;
                    PC_rectTransform.sizeDelta = new Vector2(750f, 3700f);
                    PC_scrollBar.value = 1;

                    for (int i = 0; i < 6; i++)
                    {
                        PC_news[i].SetActive(true);
                    }
                    PC_news[6].SetActive(false);

                }
                else
                {
                    UpgradesLogic.newsQuantity = 6;
                    rectTransform.sizeDelta = new Vector2(750f, 3800f);
                    scrollBar.value = 1;

                    for (int i = 0; i < 6; i++)
                    {
                        news[i].SetActive(true);
                    }
                    news[6].SetActive(false);

                }

                break;
            case 3:

                if (UIDisplay.isPC)
                {
                    UpgradesLogic.newsQuantity = 7;
                    PC_rectTransform.sizeDelta = new Vector2(750f, 4500f);
                    PC_scrollBar.value = 1;

                    for (int i = 0; i < 7; i++)
                    {
                        PC_news[i].SetActive(true);
                    }

                }
                else
                {
                    UpgradesLogic.newsQuantity = 7;
                    rectTransform.sizeDelta = new Vector2(750f, 4600f);
                    scrollBar.value = 1;

                    for (int i = 0; i < 7; i++)
                    {
                        news[i].SetActive(true);
                    }

                }

                break;
            default:

                if (UIDisplay.isPC)
                {
                    PC_rectTransform.sizeDelta = new Vector2(750f, 2100f);
                    PC_scrollBar.value = 1;

                    for (int i = 0; i < 4; i++)
                    {
                        PC_news[i].SetActive(true);

                    }

                }
                else
                {
                    rectTransform.sizeDelta = new Vector2(750f, 2200f);
                    scrollBar.value = 1;

                    for (int i = 0; i < 4; i++)
                    {
                        news[i].SetActive(true);
                    }

                }

                break;
        }
    }

    public void DisplaySelectedNews()
    {
        if(UIDisplay.isPC)
        {
            PC_companyName.text = ChooseNameLogic.nameString;

            for (int i = 0; i < newsSelectedList.Count; i++)
            {
                PC_titleNewspaper[i].text = newsSelectedList[i].titleText.text;
                PC_shortNewspaperDescription[i].text = newsSelectedList[i].shortDescriptionText.text;
                PC_newspaperImage[i].sprite = newsSelectedList[i].newImage.sprite;
            }
        }
        else
        {
            companyName.text = ChooseNameLogic.nameString;

            for (int i = 0; i < newsSelectedList.Count; i++)
            {
                titleNewspaper[i].text = newsSelectedList[i].titleText.text;
                shortNewspaperDescription[i].text = newsSelectedList[i].shortDescriptionText.text;
                newspaperImage[i].sprite = newsSelectedList[i].newImage.sprite;
            }
        }
        
    }
}
