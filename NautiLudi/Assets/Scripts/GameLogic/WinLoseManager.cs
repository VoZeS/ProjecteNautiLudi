using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinLoseManager : MonoBehaviour
{
    public TMP_Text[] newsTitle;
    public TMP_Text[] newsLoses;
    public TMP_Text[] newsWins;
    [Space(10)]
    public TMP_Text totalLost;
    public TMP_Text totalWon;
    [Space(10)]
    public TMP_Text totalBalance;
    [Space(10)]
    public TMP_Text actualMoney;
    [Space(10)]
    public ParticleSystem[] confetiParticles;

    public AudioSource moneyGained;
    public AudioSource moneyLost;   

    static public bool hasLost = false;
    static public double totalBal;

    public void SetAllBalances()
    {
        SetTitles();
        SetNewsBalance();
        SetTotalLost();
        SetTotalWon();
        SetTotalBalance();
    }

    public void SetTitles()
    {
        for (int i = 0; i < NewsLogic.newsSelectedList.Count; i++)
        {
            newsTitle[i].text = NewsLogic.newsSelectedList[i].titleText.text;
        }
    }

    public void SetNewsBalance()
    {
        for (int i = 0; i < NewsLogic.newsSelectedList.Count; i++)
        {
            newsLoses[i].text = "-" + NewsLogic.newsSelectedList[i].moneyCost.ToString("F2") + "€";
            newsWins[i].text = "+" + ScoreLogic.newWins[i].ToString("F2") + "€";
        }
    }

    public void SetTotalLost()
    {
        double negativeBalance = 0;

        for(int i = 0; i < NewsLogic.newsSelectedList.Count; i++)
        {
            negativeBalance -= NewsLogic.newsSelectedList[i].moneyCost;
        }

        totalLost.text = negativeBalance.ToString("F2") + "€";
    }

    public void SetTotalWon()
    {
        double positiveBalance = 0;

        for(int i = 0; i < NewsLogic.newsSelectedList.Count; i++)
        {
            positiveBalance += ScoreLogic.newWins[i];
        }

        totalWon.text = "+" + positiveBalance.ToString("F2") + "€";
    }

    public void SetTotalBalance()
    {
        totalBal = 0;

        for(int i = 0; i < NewsLogic.newsSelectedList.Count; i++)
        {
            totalBal -= NewsLogic.newsSelectedList[i].moneyCost;
            totalBal += ScoreLogic.newWins[i];
        }

        if (totalBal >= 0) // ---------------------------------------- WIN
        {
            totalBalance.text = "+" + totalBal.ToString("F2") + "€";
            totalBalance.color = new Color(60 / 255f, 180 / 255f, 70 / 255f, 1); // GREEN

            // CONFETI
            for(int i = 0; i < confetiParticles.Length; i++)
            {
                confetiParticles[i].Play();
            }

            moneyGained.Play();  
        }
        else if (totalBal < 0) // ------------------------------------- LOSE
        {
            totalBalance.text = totalBal.ToString() + "€";
            totalBalance.color = new Color(200 / 255f, 50 / 255f, 50 / 255f, 1); // RED

            moneyLost.Play();
        }

        actualMoney.text = MoneyLogic.totalMoney.ToString("F2") + "€";

        if (MoneyLogic.totalMoney < 0)
        {
            actualMoney.color = new Color(200 / 255f, 50 / 255f, 50 / 255f, 1); // RED
            hasLost = true;
        }
        else if (MoneyLogic.totalMoney >= 0)
        {
            actualMoney.color = new Color(60 / 255f, 180 / 255f, 70 / 255f, 1); // GREEN
            hasLost = false;
        }

    }
}
