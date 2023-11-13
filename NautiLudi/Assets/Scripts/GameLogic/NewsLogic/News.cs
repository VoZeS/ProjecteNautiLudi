using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class News
{
    [Header("Visual")]
    public string title;
    public string shortDescription;
    public string extendedDescription;
    public string newsImage;
    public string url;

    [Header("Logic")]
    public int socialValue;
    public int sportsValue;
    public int internationalValue;
    public int moneyCost;
    public bool isBlocked = true;
    public bool isSelected = false;

}
