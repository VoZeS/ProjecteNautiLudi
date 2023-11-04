using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class NewsTextLogic : MonoBehaviour
{
    public TMP_Text newsSelectedText;
    static public int selectedNews;

    private void Start()
    {
        selectedNews = 0;
    }

    // Update is called once per frame
    void Update()
    {
        newsSelectedText.text = "Noticies seleccionades: " + selectedNews + "/3";
    }
}
