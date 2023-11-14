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
    public Button PC_quantityButton;
    public Image[] PC_quantityLevelImage;
    [Space(10)]
    public TMP_Text quantityCostDisplay;
    public TMP_Text PC_quantityCostDisplay;
    public int quantityCost;

    [Header("Free News Upgrade")]
    //static public int freeNews;
    static public int freeLevel;
    public Button freeButton;
    public Image[] freeLevelImage;
    public Button PC_freeButton;
    public Image[] PC_freeLevelImage;
    [Space(10)]
    public TMP_Text freeCostDisplay;
    public TMP_Text PC_freeCostDisplay;
    public int freeCost;

    [Header("More Impressions Upgrade")]
    static public int impressionsLevel;
    public Button impressionsButton;
    public Image[] impressionsLevelImage;
    public Button PC_impressionsButton;
    public Image[] PC_impressionsLevelImage;
    [Space(10)]
    public TMP_Text impressionsCostDisplay;
    public TMP_Text PC_impressionsCostDisplay;
    public int impressionsCost;

    public AudioSource error;
    public AudioSource success;

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
            Debug.Log("El GameObject gameManager no se ha encontrado en la escena. Aseg�rate de que est� presente y tiene el nombre 'GameManager'.");
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
        if(UIDisplay.isPC)
        {
            if (quantityLevel < 3)
                PC_quantityCostDisplay.text = quantityCost.ToString();
            else if (quantityLevel >= 3)
            {
                PC_quantityCostDisplay.text = "M�xim";
                PC_quantityButton.gameObject.SetActive(false);
            }
        }
        else
        {
            if (quantityLevel < 3)
                quantityCostDisplay.text = quantityCost.ToString();
            else if (quantityLevel >= 3)
            {
                quantityCostDisplay.text = "M�xim";
                quantityButton.gameObject.SetActive(false);
            }
        }
        
        
        // ----------------------------------------------------------------- FREE NEWS UPGRADE
        if(UIDisplay.isPC)
        {
            if (freeLevel < 2)
                PC_freeCostDisplay.text = freeCost.ToString();
            else if (freeLevel >= 2)
            {
                PC_freeCostDisplay.text = "M�xim";
                PC_freeButton.gameObject.SetActive(false);
            }
        }
        else
        {
            if (freeLevel < 2)
                freeCostDisplay.text = freeCost.ToString();
            else if (freeLevel >= 2)
            {
                freeCostDisplay.text = "M�xim";
                freeButton.gameObject.SetActive(false);
            }
        }
        
        
        // ----------------------------------------------------------------- FREE NEWS UPGRADE
        if(UIDisplay.isPC)
        {
            if (impressionsLevel < 3)
                PC_impressionsCostDisplay.text = impressionsCost.ToString();
            else if (impressionsLevel >= 3)
            {
                PC_impressionsCostDisplay.text = "M�xim";
                PC_impressionsButton.gameObject.SetActive(false);
            }
        }
        else
        {
            if (impressionsLevel < 3)
                impressionsCostDisplay.text = impressionsCost.ToString();
            else if (impressionsLevel >= 3)
            {
                impressionsCostDisplay.text = "M�xim";
                impressionsButton.gameObject.SetActive(false);
            }
        }
       

    }

    public void AddNewsUpgrade()
    {
        if(MoneyLogic.totalMoney - quantityCost >= 0 && quantityLevel < 3)
        {
            MoneyLogic.totalMoney -= quantityCost;

            newsQuantity++;
            quantityLevel++;

            success.Play();
            UpdateQuantityUpgradeDisplay();

            if (managerScript != null)
                managerScript.SaveGame();
        }
        else
        {
            // SONIDO DE ERROR
            error.Play();
        }
        
    }

    public void FreeNewsUpgrade()
    {
        if (MoneyLogic.totalMoney - freeCost >= 0 && freeLevel < 2)
        {
            MoneyLogic.totalMoney -= freeCost;

            //freeNews++;
            freeLevel++;

            success.Play();
            UpdateFreeUpgradeDisplay();

            if(managerScript != null)
                managerScript.SaveGame();
        }
        else
        {
            // SONIDO DE ERROR
            error.Play();
        }

    }

    public void ImpressionsUpgrade()
    {
        if (MoneyLogic.totalMoney - impressionsCost >= 0 && impressionsLevel < 2)
        {
            MoneyLogic.totalMoney -= impressionsCost;

            impressionsLevel++;

            success.Play();
            UpdateImpressionsUpgradeDisplay();

            if (managerScript != null)
                managerScript.SaveGame();
        }
        else
        {
            // SONIDO DE ERROR
            error.Play();
        }
    }

    private void UpdateQuantityUpgradeDisplay()
    {
        switch (quantityLevel)
        {
            case 0:

                if(!UIDisplay.isPC)
                {
                    quantityLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE
                }
                else
                {
                    PC_quantityLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    PC_quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    PC_quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE
                }
                
                quantityCost = 550;

                break;
            case 1:

                if(!UIDisplay.isPC)
                {
                    quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE
                }
                else
                {
                    PC_quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    PC_quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE
                }
                
                quantityCost = 750;

                break;
            case 2:

                if(!UIDisplay.isPC)
                {
                    quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE
                }
                else
                {
                    PC_quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_quantityLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE
                }
               
                quantityCost = 1000;

                break;
            case 3:
                if (!UIDisplay.isPC)
                {
                    quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    quantityLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                }
                else
                {
                    PC_quantityLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_quantityLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_quantityLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                }

                break;
            default:
                if (!UIDisplay.isPC)
                {
                    quantityLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                }
                else
                {
                    PC_quantityLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    PC_quantityLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    PC_quantityLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                }

                quantityCost = 550;

                break;
        }
    }

    private void UpdateFreeUpgradeDisplay()
    {
        switch (freeLevel)
        {
            case 0:

                if (!UIDisplay.isPC)
                {
                    freeLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                }
                else
                {
                    PC_freeLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    PC_freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                }

                //freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                freeCost = 1500;

                break;
            case 1:

                if (!UIDisplay.isPC)
                {
                    freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                }
                else
                {
                    PC_freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                }
               
                //freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                freeCost = 3000;

                break;
            case 2:
                if (!UIDisplay.isPC)
                {
                    freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    freeLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                }
                else
                {
                    PC_freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_freeLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                }
                
                //freeLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                //freeCost = 3000;

                break;
            //case 3:
            //    freeLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
            //    freeLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
            //    freeLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN

                //break;
            default:
                if (!UIDisplay.isPC)
                {
                    freeLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                }
                else
                {
                    PC_freeLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    PC_freeLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                }
               
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
                if (!UIDisplay.isPC)
                {
                    impressionsLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE
                }
                else
                {
                    PC_impressionsLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    PC_impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    PC_impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE
                }
                
                impressionsCost = 2000;

                break;
            case 1:
                if (!UIDisplay.isPC)
                {
                    impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                }
                else
                {
                    PC_impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    PC_impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                }

                impressionsCost = 4000;

                break;
            case 2:
                if (!UIDisplay.isPC)
                {
                    impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    impressionsLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                }
                else
                {
                    PC_impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_impressionsLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                }

                impressionsCost = 8000;

                break;
            case 3:
                if (!UIDisplay.isPC)
                {
                    impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    impressionsLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    impressionsLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                }
                else
                {
                    PC_impressionsLevelImage[0].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_impressionsLevelImage[1].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                    PC_impressionsLevelImage[2].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1); // GREEN
                }
               

                break;
            default:
                if (!UIDisplay.isPC)
                {
                    impressionsLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                }
                else
                {
                    PC_impressionsLevelImage[0].color = new Color(1, 1, 1, 1); //WHITE
                    PC_impressionsLevelImage[1].color = new Color(1, 1, 1, 1); //WHITE
                    PC_impressionsLevelImage[2].color = new Color(1, 1, 1, 1); //WHITE

                }

                impressionsCost = 2000;

                break;
        }
    }
}
