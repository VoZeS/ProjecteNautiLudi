using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
//using Newtonsoft.Json;

public class GameManager : MonoBehaviour
{
    private bool isNewGame = true;
    private string saveFilePath;

    // Between Scenes Logic
    private bool managerCreated = false;

    private void Awake()
    {
        if (!managerCreated)
        {
            DontDestroyOnLoad(this.gameObject);
            managerCreated = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        saveFilePath = Application.persistentDataPath + "/saveData.txt";

        if (File.Exists(saveFilePath))
        {
            isNewGame = false;
        }

        if (isNewGame)
        {
            Invoke("StartNewGame", 2.0f);
        }
        else
        {
            ContinueGame();
        }
    }

    public void StartNewGame()
    {
        Debug.Log("Starting a new game...");
        SaveGame();

    }

    public void ContinueGame()
    {
        Debug.Log("Continuing the game...");
    }

    public void SaveGame()
    {
        Debug.Log("Saving the game...");

        // Saving Data
        SaveData data = new SaveData(1, "testing", 2.3f);

        try
        {
            //string jsonData = JsonConvert.SerializeObject(data);
            //File.WriteAllText(saveFilePath, jsonData);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al guardar los datos: " + e.Message);
        }

    }

    public void LoadGame()
    {
        if (File.Exists(saveFilePath))
        {
            string jsonData = File.ReadAllText(saveFilePath);
            //SaveData data = JsonConvert.DeserializeObject<SaveData>(jsonData);

            // Use the data as needed
            //Debug.Log("Variable 1: " + data.Variable1);
            //Debug.Log("Variable 2: " + data.Variable2);
            //Debug.Log("Variable 3: " + data.Variable3);
        }
    }

    // Save Class
    public class SaveData
    {
        public int Variable1;
        public string Variable2;
        public float Variable3;

        public SaveData(int variable1, string variable2, float variable3)
        {
            Variable1 = variable1;
            Variable2 = variable2;
            Variable3 = variable3;
        }
    }
}
