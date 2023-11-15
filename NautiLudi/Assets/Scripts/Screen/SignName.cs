using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SignName : MonoBehaviour
{
    public TMP_Text signText;
    public TMP_Text signDoorText;

    private void Start()
    {
        if(ChooseNameLogic.nameString != null)
        {
            signText.text = ChooseNameLogic.nameString;
            signDoorText.text = ChooseNameLogic.nameString;
        }

    }
}
