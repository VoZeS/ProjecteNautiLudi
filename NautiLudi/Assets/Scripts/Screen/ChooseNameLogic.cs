using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChooseNameLogic : MonoBehaviour
{
    public TMP_InputField inputName;
    public TMP_Text nameText;
    static public string nameString;

    public void ChangeName()
    {
        nameString = inputName.text;
        nameText.text = nameString;
    }

    private void Start()
    {
        if(nameText != null)
            nameText.text = nameString;
    }

}
