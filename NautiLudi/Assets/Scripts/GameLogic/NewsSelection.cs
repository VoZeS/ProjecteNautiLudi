using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsSelection : MonoBehaviour
{
    private Button selectButton;
    public TMP_Text buttonText;
    public Image buttonBackground;

    private void Start()
    {
        selectButton = GetComponent<Button>();
        buttonText.text = "Seleccionar";
        buttonBackground.color = new Color(0, 100, 0, 1);
    }

    public void NewsSelectionLogic()
    {

        if (buttonText.text == "Seleccionar" && NewsTextLogic.selectedNews < 3)
        {
            NewsTextLogic.selectedNews++;
            buttonText.text = "Deseleccionar";
            buttonBackground.color = new Color(100, 0, 0, 1);

        }
        else if (buttonText.text == "Deseleccionar" && NewsTextLogic.selectedNews <= 3)
        {
            NewsTextLogic.selectedNews--;
            buttonText.text = "Seleccionar";
            buttonBackground.color = new Color(0, 100, 0, 1);

        }
    }
}