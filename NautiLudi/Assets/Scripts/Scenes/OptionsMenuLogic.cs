using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsMenuLogic : MonoBehaviour
{
    // Set to false GO
    public GameObject mainMenuGroup;

    // Set to true GO
    public GameObject optionsGroup;

    public void OpenOptionsMenu()
    {
        mainMenuGroup.SetActive(false);
        optionsGroup.SetActive(true);
    }
    public void CloseOptionsMenu()
    {
        mainMenuGroup.SetActive(true);
        optionsGroup.SetActive(false);
    }

}
