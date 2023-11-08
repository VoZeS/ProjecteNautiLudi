using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChooseNameLogic : MonoBehaviour
{
    public TMP_InputField inputName;
    public TMP_Text nameText;

    public void ChangeName()
    {
        nameText.text = inputName.text;
    }

}
