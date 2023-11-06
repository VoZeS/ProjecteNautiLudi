using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class News : MonoBehaviour
{
    public string title;
    public string shortDescription;
    public string extendedDescription;
    public Sprite newsImage;

    // Start is called before the first frame update
    void Awake()
    {
        //title = "This is the title!";
        //shortDescription = "This should be de short description. Not too much text.";
        //extendedDescription = "Here goes the extended description. This is the news introduction.\n" +
        //    "It can have multiple pharagrafs and a lot of characters. Let's see how it is done.";
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public void SetShortDescription(string newShortDescription)
    {
        shortDescription = newShortDescription;
    }

    public void SetExtendedDescription(string newExtendedDescription)
    {
        extendedDescription = newExtendedDescription;
    }
}
