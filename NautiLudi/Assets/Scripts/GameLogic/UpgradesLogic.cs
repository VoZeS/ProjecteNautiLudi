using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesLogic : MonoBehaviour
{
    [Header("Game Manager")]
    public GameManagement managerScript;

    [Header("Quantity News Upgrade")]
    static public int newsQuantity;
    static public int quantityLevel;
    public Button quantityButton;
    public Image[] quantityLevelImage;
    [Space(10)]
    public TMP_Text quantityCostDisplay;
    public int quantityCost;

    [Header("Free News Upgrade")]
    //static public int freeNews;
    static public int freeLevel;
    public Button freeButton;
    public Image[] freeLevelImage;
    [Space(10)]
    public TMP_Text freeCostDisplay;
    public int freeCost;

    [Header("More Impressions Upgrade")]
    static public int impressionsLevel;
    public Button impressionsButton;
    public Image[] impressionsLevelImage;
    [Space(10)]
    public TMP_Text impressionsCostDisplay;
    public int impressionsCost;

    private void Start()
    {
        // ----------------------------------------------------------------- GAME MANAGER
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

        // ----------------------------------------------------------------- QUANTITY UPGRADE
        //newsQuantity = 4;
        //quantityLevel = 0;

        UpdateQuantityUpgradeDisplay();

        // ----------------------------------------------------------------- FREE NEWS UPGRADE
        //freeNews = 0;
        //freeLevel = 0;

        UpdateFreeUpgradeDisplay();

        // ----------------------------------------------------------------- IMPRESSIONS UPGRADE
        //impressionsLevel = 0;

        UpdateImpressionsUpgradeDisplay();
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
        if (freeLevel < 2)
            freeCostDisplay.text = freeCost.ToString();
        else if(freeLevel >= 2)
        {
            freeCostDisplay.text = "Màxim";
            freeButton.gameObject.SetActive(false);
        }
        
        // ----------------------------------------------------------------- FREE NEWS UPGRADE
        if (impressionsLevel < 3)
            impressionsCostDisplay.text = impressionsCost.ToString();
        else if(impressionsLevel >= 3)
        {
            impressionsCostDisplay.text = "Màxim";
            impressionsButton.gameObject.SetActive(false);
        }

    }

    public void AddNewsUpgrade()
    {
        if(MoneyLogic.totalMoney - quantityCost >= 0 && quantityLevel < 3)
        {
            MoneyLogic.totalMoney -= quantityCost;

            newsQuantity++;
            quantityLevel++;

            UpdateQuantityUpgradeDisplay();

            if (managerScript != null)
                managerScript.SaveGame();
        }
        else
        {
            // SONIDO DE ERROR
        }
        
    }

    public void FreeNewsUpgrade()
    {
        if (MoneyLogic.totalMoney - freeCost >= 0 && freeLevel < 2)
        {
            MoneyLogic.totalMoney -= freeCost;

            //freeNews++;
            freeLevel++;

            UpdateFreeUpgradeDisplay();

            if(managerScript != null)
                managerScript.SaveGame();
        }
        else
        {
            // SONIDO DE ERROR
        }

    }

    public void ImpressionsUpgrade()
    {
        if (MoneyLogic.totalMoney - impressionsCost >= 0 && impressionsLevel < 2)
        {
            MoneyLogic.totalMoney -= impressionsCost;

            impressionsLevel++;

            UpdateImpressionsUpgradeDisplay();

            if (managerScript != null)
                managerScript.SaveGame();
        }
        else
        {
            // SONIDO DE ERROR
        }
    }

    private void UpdateQuantityUpgradeDisplay()
    {
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

    private void UpdateFreeUpgradeDisplay()
    {
        switch (freeLevel)
        {
            case 0:
                freeLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                //freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                freeCost = 1500;

                break;
            case 1:
                freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                //freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                freeCost = 3000;

                break;
            case 2:
                freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                freeLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                //freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                //freeCost = 3000;

                break;
            //case 3:
            //    freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
            //    freeLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
            //    freeLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN

                //break;
            default:
                freeLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                //freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                freeCost = 1500;

                break;
        }
    }

    private void UpdateImpressionsUpgradeDisplay()
    {
        switch (impressionsLevel)
        {
            case 0:
                impressionsLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                impressionsCost = 2000;

                break;
            case 1:
                impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                impressionsCost = 4000;

                break;
            case 2:
                impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                impressionsLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                impressionsCost = 8000;

                break;
            case 3:
                impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                impressionsLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                impressionsLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN

                break;
            default:
                impressionsLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                impressionsCost = 2000;

                break;
        }
    }
}
