using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLogic : MonoBehaviour
{
    public GameManagement managerScript;

    public GameObject[] tutorialMobileImages;
    public GameObject[] tutorialPCImages;

    // Start is called before the first frame update
    void Start()
    {

        GameObject gameManager = GameObject.Find("GameManager");
        if (gameManager != null)
        {
            managerScript = gameManager.GetComponent<GameManagement>();
            if (managerScript == null)
            {
                Debug.Log("El GameObject optionsGroup no tiene el componente GameManagement adjunto.");
            }
        }
        else
        {
            Debug.Log("El GameObject gameManager no se ha encontrado en la escena. Aseg�rate de que est� presente y tiene el nombre 'GameManager'.");
        }

        if (GameManagement.hasPlayed)
        {
            for (int i = 0; i < tutorialMobileImages.Length; i++)
            {
                tutorialMobileImages[i].SetActive(false);
                tutorialPCImages[i].SetActive(false);
            }
        }
        else if (!GameManagement.hasPlayed)
        {
            tutorialMobileImages[0].SetActive(true);
            tutorialPCImages[0].SetActive(true);

        }
    }

    public void SetPlayability(bool played)
    {
        GameManagement.hasPlayed = played;

        if (managerScript != null)
            managerScript.SaveGame();
    }

    public void ActivateNewsTutorial()
    {
        if (!GameManagement.hasPlayed)
        {
            tutorialMobileImages[2].SetActive(true);
            tutorialPCImages[2].SetActive(true);
        }
    }
}
