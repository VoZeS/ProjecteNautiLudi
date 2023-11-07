using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyLogic : MonoBehaviour
{
    public TMP_Text moneyDisplay;
    public double totalMoney;

    static public double moneyGained;
    private int moneySpent;

    private void Update()
    {
        moneyDisplay.text = totalMoney.ToString();
    }

    public void BuyNew(News news)
    {
        moneySpent = news.moneyCost;

        if (NewsLogic.newsSelectedList.Contains(news))
            totalMoney -= moneySpent;
        else if (!NewsLogic.newsSelectedList.Contains(news) && !news.isBlocked)
        {
            totalMoney += moneySpent;
            news.isBlocked = true;
        }
    }

    public void NewspaperBenefits()
    {
        totalMoney += moneyGained;
        moneyGained = 0;
    }
}
