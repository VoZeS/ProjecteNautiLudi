using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyLogic : MonoBehaviour
{
    public TMP_Text moneyDisplay;
    [Space(10)]
    public TMP_Text PC_moneyDisplay;

    static public double totalMoney;

    static public double moneyGained;
    private int moneySpent;

    private void Update()
    {
        if(UIDisplay.isPC)
        {
            PC_moneyDisplay.text = totalMoney.ToString("F2") + "�";
        }
        else
        {
            moneyDisplay.text = totalMoney.ToString("F2") + "�";
        }

        if (totalMoney < 0)
            SetMoneyTextColor(new Color(230 / 255f, 100 / 255f, 100 / 255f, 1)); // RED
        else if (totalMoney >= 0)
            SetMoneyTextColor(new Color(60/255f, 180/255f, 70/255f, 1)); // GREEN

    }

    public void BuyNew(NewsObject news)
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
        for(int i = 0; i < NewsLogic.newsSelectedList.Count; i++)
        {
            totalMoney += ScoreLogic.newWins[i];
        }
    }

    public void SetMoneyTextColor(Color color)
    {
        if (UIDisplay.isPC)
        {
            PC_moneyDisplay.color = color;
        }
        else
        {
            moneyDisplay.color = color;
        }
    }
}
