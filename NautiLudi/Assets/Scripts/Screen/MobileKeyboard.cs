using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileKeyboard : MonoBehaviour
{
    public InputField inputField;

    public void OpenKeyboard()
    {
        inputField.ActivateInputField();
    }

    public void CloseKeyboard()
    {
        inputField.DeactivateInputField();
    }
}
