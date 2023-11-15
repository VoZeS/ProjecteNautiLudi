using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLogic : MonoBehaviour
{
    private int[] points;

    private int maxMoneyReward;

    static public double[] newWins;

    public void CheckNewspaper()
    {
        points = new int[NewsLogic.newsSelectedList.Count];

        newWins = new double[NewsLogic.newsSelectedList.Count];

        //Phase 0: Stablish Reward
        maxMoneyReward = 750;
        for (int j = 0; j < NewsLogic.newsSelectedList.Count; j++)
        {
            maxMoneyReward += NewsLogic.newsSelectedList[j].moneyCost;
        }

        switch(UpgradesLogic.impressionsLevel)
        {
            case 0:
                maxMoneyReward /= NewsLogic.newsSelectedList.Count;
                break;

            case 1:
                maxMoneyReward += 100;
                maxMoneyReward /= NewsLogic.newsSelectedList.Count;
                break;

            case 2:
                maxMoneyReward += 200;
                maxMoneyReward /= NewsLogic.newsSelectedList.Count;
                break;

            case 3:
                maxMoneyReward += 300;
                maxMoneyReward /= NewsLogic.newsSelectedList.Count;
                break;

            default:
                maxMoneyReward /= NewsLogic.newsSelectedList.Count;
                break;
        }

        for (int i = 0; i < NewsLogic.newsSelectedList.Count; i++)
        {
            

            // Phase 1: Comparison
            int socialComparison, sportsComparison, interComparison;

            socialComparison = Mathf.Abs(NewsLogic.newsSelectedList[i].socialValue - RandomInterests.socialInterestSlider);
            sportsComparison = Mathf.Abs(NewsLogic.newsSelectedList[i].sportsValue - RandomInterests.sportsInterestSlider);
            interComparison = Mathf.Abs(NewsLogic.newsSelectedList[i].internationalValue - RandomInterests.internationalInterestSlider);

            // Phase 2: Punctuation
            switch(socialComparison)
            {
                case 0:
                    points[i] += 3;
                    break;
                case 1:
                    points[i] += 1;
                    break;
                case 2:
                    points[i] += 0;
                    break;
                default:
                    points[i] += 0;
                    break;
            }

            switch(sportsComparison)
            {
                case 0:
                    points[i] += 3;
                    break;
                case 1:
                    points[i] += 1;
                    break;
                case 2:
                    points[i] += 0;
                    break;
                default:
                    points[i] += 0;
                    break;
            }

            switch(interComparison)
            {
                case 0:
                    points[i] += 3;
                    break;
                case 1:
                    points[i] += 1;
                    break;
                case 2:
                    points[i] += 0;
                    break;
                default:
                    points[i] += 0;
                    break;
            }

            // Phase 3: Transformation
            MoneyLogic.moneyGained = 0;

            switch (points[i])
            {
                case 9:
                    MoneyLogic.moneyGained += maxMoneyReward;
                    break;
                case 7:
                    MoneyLogic.moneyGained += maxMoneyReward * 0.8;
                    break;
                case 6:
                    MoneyLogic.moneyGained += maxMoneyReward * 0.6;
                    break;
                case 5:
                    MoneyLogic.moneyGained += maxMoneyReward * 0.5;
                    break;
                case 4:
                    MoneyLogic.moneyGained += maxMoneyReward * 0.4;
                    break;
                case 3:
                    MoneyLogic.moneyGained += maxMoneyReward * 0.3;
                    break;
                case 2:
                    MoneyLogic.moneyGained += maxMoneyReward * 0.2;
                    break;
                case 1:
                    MoneyLogic.moneyGained += maxMoneyReward * 0.1;
                    break;
                case 0:
                    MoneyLogic.moneyGained += maxMoneyReward * 0;
                    break;
            }

            newWins[i] = MoneyLogic.moneyGained;

            Debug.Log(MoneyLogic.moneyGained);

        }
    }
}
