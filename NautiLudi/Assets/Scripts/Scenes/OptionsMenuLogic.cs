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

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    public void OpenOptionsMenu()
    {
        if(mainMenuGroup != null)
            mainMenuGroup.SetActive(false);

        optionsGroup.SetActive(true);
    }
    public void CloseOptionsMenu()
    {
        if (mainMenuGroup != null)
            mainMenuGroup.SetActive(true);

        optionsGroup.SetActive(false);
    }

}
