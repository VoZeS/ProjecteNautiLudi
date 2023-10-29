using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsManagerBetweenScenes : MonoBehaviour
{
    private OptionsMenuLogic optionsScript;

    private void Start()
    {
        optionsScript = GameObject.FindGameObjectWithTag("OptionsManager").GetComponent<OptionsMenuLogic>();

        if (optionsScript == null)
        {
            Debug.Log("El GameObject optionsGroup no se ha asignado. Asigna el GameObject en el editor de Unity.");
            return;
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
