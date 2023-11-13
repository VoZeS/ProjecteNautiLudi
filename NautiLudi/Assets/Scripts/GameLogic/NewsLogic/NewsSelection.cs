using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsSelection : MonoBehaviour
{
    private bool areButtonsLinked = true;
    private bool isSelectButtonClicked = false;
    private bool isAssociateButtonClicked = false;

    private Button selectButton;

    [Header("Main Button")]
    public TMP_Text buttonText;
    public Image buttonBackground;

    [Header("Associate Button")]
    public Button associateSelectButton;
    public TMP_Text associateButtonText;
    public Image associateButtonBackground;

    private void Start()
    {
        selectButton = GetComponent<Button>();
        buttonText.text = "Seleccionar";
        buttonBackground.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1);

        associateButtonText.text = "Seleccionar";
        associateButtonBackground.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1);

        selectButton.onClick.AddListener(OnSelectClick);
        associateSelectButton.onClick.AddListener(OnAssociateSelectClick);
    }

    public void OnSelectClick()
    {
        if (areButtonsLinked && !isAssociateButtonClicked)
        {
            isSelectButtonClicked = true;
            associateSelectButton.onClick.Invoke();
            isSelectButtonClicked = false;
        }

        NewsSelectionLogic();

    }

    public void OnAssociateSelectClick()
    {
        if (areButtonsLinked && !isSelectButtonClicked)
        {
            isAssociateButtonClicked = true;
            selectButton.onClick.Invoke();
            isAssociateButtonClicked = false;
        }

        AssociateNewsSelectionLogic();

    }

    public void NewsSelectionLogic()
    {

        if (buttonText.text == "Seleccionar" && NewsLogic.selectedNews < 3)
        {
            NewsLogic.selectedNews += 0.5;
            buttonText.text = "Deseleccionar";
            buttonBackground.color = new Color(240f / 255f, 80f / 255f, 70f / 255f, 1);

        }
        else if (buttonText.text == "Deseleccionar" && NewsLogic.selectedNews <= 3)
        {
            NewsLogic.selectedNews -= 0.5;
            buttonText.text = "Seleccionar";
            buttonBackground.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1);

        }
    }

    public void AssociateNewsSelectionLogic()
    {

        if (associateButtonText.text == "Seleccionar" && NewsLogic.selectedNews < 3)
        {
            NewsLogic.selectedNews += 0.5;
            associateButtonText.text = "Deseleccionar";
            associateButtonBackground.color = new Color(240f / 255f, 80f / 255f, 70f / 255f, 1);

        }
        else if (associateButtonText.text == "Deseleccionar" && NewsLogic.selectedNews <= 3)
        {
            NewsLogic.selectedNews -= 0.5;
            associateButtonText.text = "Seleccionar";
            associateButtonBackground.color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1);

        }
    }

    public void RealSelectionLogic(NewsObject news)
    {
        if ((buttonText.text == "Seleccionar" || associateButtonText.text == "Seleccionar") && NewsLogic.selectedNews < 3)
        {
            if (!NewsLogic.newsSelectedList.Contains(news) && NewsLogic.newsSelectedList.Count < 3)
            {
                NewsLogic.newsSelectedList.Add(news);
            }
        }
        else if ((buttonText.text == "Deseleccionar" || associateButtonText.text == "Deseleccionar") && NewsLogic.selectedNews <= 3)
        {
            if (NewsLogic.newsSelectedList.Contains(news))
            {
                NewsLogic.newsSelectedList.Remove(news);
            }
        }
    }

}