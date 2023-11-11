using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesLogic : MonoBehaviour
{
    [Header("Quantity News Upgrade")]
    static public int newsQuantity;
    private int quantityLevel;
    public Button quantityButton;
    public Image[] quantityLevelImage;
    [Space(10)]
    public TMP_Text quantityCostDisplay;
    public int quantityCost;

    [Header("Free News Upgrade")]
    private int freeLevel;
    public Button freeButton;
    public Image[] freeLevelImage;
    [Space(10)]
    public TMP_Text freeCostDisplay;
    public int freeCost;

    private void Start()
    {
        // ----------------------------------------------------------------- QUANTITY UPGRADE
        newsQuantity = 4;
        quantityLevel = 0;

        for(int i = 0; i < quantityLevelImage.Length; i++)
        {
            quantityLevelImage[i].color = new Color(1, 1, 1, 1); //WHITE

        }

        // ----------------------------------------------------------------- FREE NEWS UPGRADE
        freeLevel = 0;

        for (int i = 0; i < freeLevelImage.Length; i++)
        {
            freeLevelImage[i].color = new Color(1, 1, 1, 1); //WHITE

        }
    }

    private void Update()
    {
        // ----------------------------------------------------------------- QUANTITY UPGRADE
        if (quantityLevel < 3)
            quantityCostDisplay.text = quantityCost.ToString();
        else if(quantityLevel >= 3)
        {
            quantityCostDisplay.text = "Màxim";
            quantityButton.gameObject.SetActive(false);
        }  
        
        // ----------------------------------------------------------------- FREE NEWS UPGRADE
        if (freeLevel < 3)
            freeCostDisplay.text = freeCost.ToString();
        else if(freeLevel >= 3)
        {
            freeCostDisplay.text = "Màxim";
            freeButton.gameObject.SetActive(false);
        }

    }

    public void AddNewsUpgrade()
    {
        if(MoneyLogic.totalMoney - quantityCost >= 0 && quantityLevel < 3)
        {
            MoneyLogic.totalMoney -= quantityCost;

            newsQuantity++;
            quantityLevel++;

            switch (quantityLevel)
            {
                case 0:
                    quantityLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                    quantityCost = 550;

                    break;
                case 1:
                    quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                    quantityCost = 750;

                    break;
                case 2:
                    quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                    quantityCost = 1000;

                    break;
                case 3:
                    quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN

                    break;
                default:
                    quantityLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                    quantityCost = 550;

                    break;
            }
        }
        else
        {
            // SONIDO DE ERROR
        }
        
    }

    public void FreeNewsUpgrade()
    {
        if (MoneyLogic.totalMoney - freeCost >= 0 && freeLevel < 3)
        {
            MoneyLogic.totalMoney -= freeCost;

            freeLevel++;

            switch (freeLevel)
            {
                case 0:
                    freeLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                    freeCost = 1000;

                    break;
                case 1:
                    freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                    freeCost = 2000;

                    break;
                case 2:
                    freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    freeLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                    freeCost = 3000;

                    break;
                case 3:
                    freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    freeLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    freeLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN

                    break;
                default:
                    freeLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                    freeCost = 1000;

                    break;
            }
        }
        else
        {
            // SONIDO DE ERROR
        }

    }
}
