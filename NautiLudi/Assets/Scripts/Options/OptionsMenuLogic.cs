using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class OptionsMenuLogic : MonoBehaviour
{
    // Set to false GO
    private GameObject mainMenuGroup;

    // Set to true GO
    public GameObject optionsGroup;
    public GameObject optionsMainMenu;
    public GameObject optionsGameplay;


    // Between Scenes Logic
    private static bool optionsCreated = false;
    private ChangeScene sceneScript;

    public Button goToMainMenuButton;

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

        GameObject gameLogicManager = GameObject.Find("GameLogicManager");
        if (gameLogicManager == null)
        {
            Debug.Log("El GameObject GameLogicManager no se ha encontrado. Asegúrate de que el objeto existe en la escena.");
            return;
        }

        sceneScript = gameLogicManager.GetComponent<ChangeScene>();

        if (sceneScript == null)
        {
            Debug.Log("El componente ChangeScene no se ha encontrado en el objeto GameLogicManager.");
            return;
        }


        goToMainMenuButton.onClick.AddListener(GoToMainMenu);
    }

    public void GoToMainMenu()
    {
        sceneScript.GoToScene("MainMenuScene");
    }

    public void OpenOptionsMenu()
    {
        if(SceneManager.GetActiveScene().name == "MainMenuScene")
        {
            if (mainMenuGroup == null)
                mainMenuGroup = GameObject.Find("_MainMenu");

            if (optionsGroup != null)
            {
                optionsGroup.SetActive(true);

                if (optionsMainMenu != null)
                {
                    optionsMainMenu.SetActive(true);
                    optionsGameplay.SetActive(false);
                }

            }
        }
        else if(SceneManager.GetActiveScene().name == "GameplayScene")
        {
            if (optionsGroup != null)
            {
                optionsGroup.SetActive(true);

                if (optionsGameplay != null)
                {
                    optionsGameplay.SetActive(true);
                    optionsMainMenu.SetActive(false);
                }
            }
        }

    }
    public void CloseOptionsMenu()
    {
        if (SceneManager.GetActiveScene().name == "MainMenuScene")
        {
            if (mainMenuGroup == null)
                mainMenuGroup = GameObject.Find("_MainMenu");

            if (mainMenuGroup != null)
                mainMenuGroup.SetActive(true);

            if (optionsGroup != null)
            {
                optionsGroup.SetActive(false);

                if (optionsMainMenu != null)
                {
                    optionsMainMenu.SetActive(true);
                    optionsGameplay.SetActive(false);
                }

            }
        }
        else if (SceneManager.GetActiveScene().name == "GameplayScene")
        {
            if (optionsGroup != null)
            {
                optionsGroup.SetActive(false);

                if (optionsGameplay != null)
                {
                    optionsGameplay.SetActive(true);
                    optionsMainMenu.SetActive(false);
                }

            }
        }
    }

}
