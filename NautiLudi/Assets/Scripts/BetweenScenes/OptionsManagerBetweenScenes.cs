using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsManagerBetweenScenes : MonoBehaviour
{
    private OptionsMenuLogic optionsScript;

    private void Start()
    {
        GameObject optionsGroup = GameObject.FindGameObjectWithTag("OptionsManager");
        if (optionsGroup != null)
        {
            optionsScript = optionsGroup.GetComponent<OptionsMenuLogic>();
            if (optionsScript == null)
            {
                Debug.Log("El GameObject optionsGroup no tiene el componente OptionsMenuLogic adjunto.");
            }
        }
        else
        {
            Debug.Log("El GameObject optionsGroup no se ha encontrado en la escena. Asegúrate de que está presente y tiene la etiqueta 'OptionsManager'.");
        }

    }

    public void OpenOptions()
    {
        if(optionsScript != null)
            optionsScript.OpenOptionsMenu();
    }

    public void CloseOptions()
    {
        if(optionsScript != null)
        {
            optionsScript.CloseOptionsMenu();
        }
    }
}
