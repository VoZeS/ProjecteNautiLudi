using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
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

        saveFilePath = Application.persistentDataPath + "/saveData.json";

        if (File.Exists(saveFilePath))
        {
            isNewGame = false;
        }

        if (isNewGame)
        {
            SaveGame();
            LoadGame();
        }
        else
        {
            ContinueGame();
        }
    }

    private void Start()
    {
        
    }

    public void StartNewGame()
    {
        Debug.Log("Starting a new game...");
        SaveGame();
        LoadGame();

        Invoke("NewGameButtonClicked", 3.0f);
    }

    public void NewGameButtonClicked()
    {
        SceneManager.LoadScene("GameplayScene");

    }

    public void ContinueGame()
    {
        Debug.Log("Continuing the game...");
        LoadGame();
    }

    public void SaveGame()
    {
        Debug.Log("Saving the game...");

        // TODO: Mirar esto ESTA MAL
        try
        {
            PlayerData playerData = new PlayerData
            {
                companyName = "...",
                playerStats = new PlayerStats
                {
                    day = 1,
                    money = 500
                },
                settings = new Settings
                {
                    music = "on",
                    fx = "on"
                }
            };

            string jsonData = JsonConvert.SerializeObject(playerData, Formatting.Indented);
            File.WriteAllText(saveFilePath, jsonData);
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
            PlayerData playerData = JsonConvert.DeserializeObject<PlayerData>(jsonData);

            // ----------------------------------------------- Load All Necessary Data
            // Company Name (MAIN MEN)
            ChooseNameLogic.nameString = playerData.companyName;

            // Gameplay Logic (IN-GAME)
            // Day, money, upgrades
        }
    }

    // Save Class
    public class PlayerData
    {
        public string companyName;

        public PlayerStats playerStats;
        public Settings settings;
    }

    public class PlayerStats
    {
        public int day, money;

        // ADD UPGRADES
    }

    public class Settings
    {
        public string music;
        public string fx;
    }
}
