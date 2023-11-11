using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScreenLogic : MonoBehaviour
{
    public TMP_Text endText;
    public TMP_Text negativeBalance;

    // Start is called before the first frame update
    void Start()
    {
        negativeBalance.text = MoneyLogic.totalMoney.ToString("F2") + "€";
        endText.text = ChooseNameLogic.nameString + " no ha pogut subsistir... El teu viatge ha arribat a la fi.";
    }

}
