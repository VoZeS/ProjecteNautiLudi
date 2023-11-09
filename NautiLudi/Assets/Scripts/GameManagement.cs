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

    // VALORES INICIALES IN-GAME
    public const int INITIALMONEY = 500;
    public const string INITIALCOMPANYNAME = "...";

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
            StartNewGame();
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

        try
        {
            PlayerData playerData = new PlayerData
            {
                companyName = INITIALCOMPANYNAME,
                playerStats = new PlayerStats
                {
                    day = 1,
                    money = INITIALMONEY
                },
                settings = new Settings
                {
                    isMusicActive = true,
                    isFxActive = true
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

    public void FirstGameStart()
    {
        Invoke("GoToGameplayScene", 3.0f);

    }

    private void GoToGameplayScene()
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

        try
        {
            PlayerData playerData = new PlayerData
            {
                companyName = ChooseNameLogic.nameString,
                playerStats = new PlayerStats
                {
                    day = RandomInterests.dayCount,
                    money = MoneyLogic.totalMoney
                },
                settings = new Settings
                {
                    isMusicActive = AudioManagement.isMusicOn,
                    isFxActive = AudioManagement.isFxOn
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
            // Load Company Name
            ChooseNameLogic.nameString = playerData.companyName;

            // Load Gameplay Logic
            RandomInterests.dayCount = playerData.playerStats.day;
            MoneyLogic.totalMoney = playerData.playerStats.money;
            AudioManagement.isMusicOn = playerData.settings.isMusicActive;
            AudioManagement.isFxOn = playerData.settings.isFxActive;

            // Checkers LOGS
            Debug.Log("Loaded company name: " + ChooseNameLogic.nameString);
            Debug.Log("Loaded day count: " + RandomInterests.dayCount);
            Debug.Log("Loaded total money: " + MoneyLogic.totalMoney);
            Debug.Log("Loaded music active: " + AudioManagement.isMusicOn);
            Debug.Log("Loaded fx active: " + AudioManagement.isFxOn);

        }
        else
        {
            Debug.LogError("Save file not found.");
        }
    }

    // Save Classes
    public class PlayerData
    {
        public string companyName;

        public PlayerStats playerStats;
        public Settings settings;
    }

    public class PlayerStats
    {
        public int day;
        public double money;

        // ADD UPGRADES
    }

    public class Settings
    {
        public bool isMusicActive;
        public bool isFxActive;
    }
}
