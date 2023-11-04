using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewsSelection : MonoBehaviour
{
    private Toggle selectToggle;
    public Text toggleText;
    public Image toggleBackground;

    private void Start()
    {
        selectToggle = GetComponent<Toggle>();
        toggleText.text = "Seleccionar";
        toggleBackground.color = new Color(0, 100, 0, 1);
    }

    public void NewsSelectionLogic()
    {

        if (selectToggle.isOn)
        {
            if (NewsTextLogic.selectedNews < 3)
            {
                NewsTextLogic.selectedNews++;
                toggleText.text = "Deseleccionar";
                toggleBackground.color = new Color(100, 0, 0, 1);
            }
        }
        else if (!selectToggle.isOn)
        {
            NewsTextLogic.selectedNews--;
            toggleText.text = "Seleccionar";
            toggleBackground.color = new Color(0, 100, 0, 1);

        }
    }
}