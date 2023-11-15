using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MobileKeyboard : MonoBehaviour
{
    public TMP_InputField inputField;

    public void OpenKeyboard()
    {
        inputField.ActivateInputField();
    }

    public void CloseKeyboard()
    {
        inputField.DeactivateInputField();
    }
}
