using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsMenuLogic : MonoBehaviour
{
    // Set to false GO
    private GameObject mainMenuGroup;

    // Set to true GO
    public GameObject optionsGroup;


    // Between Scenes Logic
    private static bool optionsCreated = false;

    private void Awake()
    {
        if (!optionsCreated)
        {
            DontDestroyOnLoad(this.gameObject);
            optionsCreated = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        mainMenuGroup = GameObject.Find("_MainMenu");

        if (mainMenuGroup == null)
        {
            Debug.Log("El GameObject mainMenuGroup no se ha asignado. Asigna el GameObject en el editor de Unity.");
            return;
        }
    }

    public void OpenOptionsMenu()
    {
        if(mainMenuGroup == null)
            mainMenuGroup = GameObject.Find("_MainMenu");

        //if (mainMenuGroup != null)
        //    mainMenuGroup.SetActive(false);

        if (optionsGroup != null)
            optionsGroup.SetActive(true);
    }
    public void CloseOptionsMenu()
    {
        if (mainMenuGroup == null)
            mainMenuGroup = GameObject.Find("_MainMenu");

        if (mainMenuGroup != null)
            mainMenuGroup.SetActive(true);

        if (optionsGroup != null)
            optionsGroup.SetActive(false);
    }

}
