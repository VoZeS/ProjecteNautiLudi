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
        buttonBackground.color = new Color(0, 100, 0, 1);

        associateButtonText.text = "Seleccionar";
        associateButtonBackground.color = new Color(0, 100, 0, 1);

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

        if (buttonText.text == "Seleccionar" && NewsTextLogic.selectedNews < 3)
        {
            NewsTextLogic.selectedNews += 0.5;
            buttonText.text = "Deseleccionar";
            buttonBackground.color = new Color(100, 0, 0, 1);

        }
        else if (buttonText.text == "Deseleccionar" && NewsTextLogic.selectedNews <= 3)
        {
            NewsTextLogic.selectedNews -= 0.5;
            buttonText.text = "Seleccionar";
            buttonBackground.color = new Color(0, 100, 0, 1);

        }
    }

    public void AssociateNewsSelectionLogic()
    {

        if (associateButtonText.text == "Seleccionar" && NewsTextLogic.selectedNews < 3)
        {
            NewsTextLogic.selectedNews += 0.5;
            associateButtonText.text = "Deseleccionar";
            associateButtonBackground.color = new Color(100, 0, 0, 1);

        }
        else if (associateButtonText.text == "Deseleccionar" && NewsTextLogic.selectedNews <= 3)
        {
            NewsTextLogic.selectedNews -= 0.5;
            associateButtonText.text = "Seleccionar";
            associateButtonBackground.color = new Color(0, 100, 0, 1);

        }
    }

}