using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLogic : MonoBehaviour
{
    public GameManagement managerScript;

    public GameObject[] tutorialImages;

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
            Debug.Log("El GameObject gameManager no se ha encontrado en la escena. Asegúrate de que está presente y tiene el nombre 'GameManager'.");
        }

        if (GameManagement.hasPlayed)
        {
            for(int i = 0; i< tutorialImages.Length; i++)
            {
                tutorialImages[i].SetActive(false);
            }
        }
    }

    public void SetPlayability(bool played)
    {
        GameManagement.hasPlayed = played;

        if(managerScript != null)
            managerScript.SaveGame();
    }

    public void ActivateNewsTutorial()
    {
        if (!GameManagement.hasPlayed)
        {
            tutorialImages[2].SetActive(true);
        }
    }
}
