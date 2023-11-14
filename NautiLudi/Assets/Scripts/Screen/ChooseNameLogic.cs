using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChooseNameLogic : MonoBehaviour
{
    public TMP_InputField inputName;
    public TMP_Text nameText;
    [Space(10)]
    public TMP_InputField PC_InputName;
    public TMP_Text PC_NameText;
    static public string nameString;

    public void ChangeName()
    {
        nameString = inputName.text;
        nameText.text = nameString;

        nameString = PC_InputName.text;
        PC_NameText.text = nameString;
    }

    private void Start()
    {
        if(!UIDisplay.isPC && nameText != null)
            nameText.text = nameString;
        
        if(UIDisplay.isPC && PC_NameText != null)
            PC_NameText.text = nameString;
    }

}
