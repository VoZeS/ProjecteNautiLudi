using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLogic : MonoBehaviour
{
    private int[] points;

    public int maxMoneyReward = 1000;

    public void CheckNewspaper()
    {
        points = new int[NewsLogic.newsSelectedList.Count];

        for(int i = 0; i < NewsLogic.newsSelectedList.Count; i++)
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
            switch(points[i])
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

            Debug.Log(MoneyLogic.moneyGained);

        }
    }
}
