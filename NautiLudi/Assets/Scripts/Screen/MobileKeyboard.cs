using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MobileKeyboard : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;

    public void OpenKeyboard()
    {
        keyboard.active = true;
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    public void CloseKeyboard()
    {
        keyboard.active = false;
    }

}
