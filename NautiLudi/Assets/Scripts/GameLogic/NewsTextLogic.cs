using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class NewsTextLogic : MonoBehaviour
{
    [Header("General Panel")]
    public TMP_Text newsSelectedText;

    [Header("Info Panel")]
    public TMP_Text[] infoNewsSelectedText;

    static public double selectedNews;

    private void Start()
    {
        selectedNews = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // ------------- General Panel -------------
        newsSelectedText.text = "Noticies seleccionades: " + selectedNews + "/3";

        // --------------- Info Panel --------------
        for(int i = 0; i < infoNewsSelectedText.Length; i++)
        {
            infoNewsSelectedText[i].text = selectedNews + "/3";

        }
    }
}
