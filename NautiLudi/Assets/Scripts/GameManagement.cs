using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    [Header("Main Menu Logic")]
    public GameObject continueButton;
    public GameObject PC_ContinueButton;
    
    private bool isNewGame = true;
    static public bool hasPlayed;
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
            hasPlayed = false;
        }
        else
        {
            ContinueGame();
        }        
    }

    private void Start()
    {
        if (hasPlayed)
        {
            if(!UIDisplay.isPC && continueButton != null)
                continueButton.SetActive(true);

            if(UIDisplay.isPC && PC_ContinueButton != null)
                PC_ContinueButton.SetActive(true);
        }
    }

    public void ContinueButtonActivation()
    {
        if(UIDisplay.isPC)
        {
            if (hasPlayed)
                PC_ContinueButton.SetActive(true);
            else if (!hasPlayed)
                PC_ContinueButton.SetActive(false);
        }
        else
        {
            if (hasPlayed)
                continueButton.SetActive(true);
            else if (!hasPlayed)
                continueButton.SetActive(false);
        }
    }

    public void StartNewGame()
    {
        Debug.Log("Starting a new game...");

        try
        {
            PlayerData playerData = new PlayerData
            {
                companyName = INITIALCOMPANYNAME,
                hasPlayedBefore = false,
                playerStats = new PlayerStats
                {
                    day = 1,
                    money = INITIALMONEY
                },
                settings = new Settings
                {
                    isMusicActive = true,
                    isFxActive = true,
                    startFxVolume = 0,
                    startMusicVolume = 0
                },
                upgrades = new Upgrades
                {
                    quantityNewsLevel = 0,
                    freeNewsLevel = 0,
                    moreImpressionsLevel = 0
                }
            };

            string jsonData = JsonConvert.SerializeObject(playerData, Formatting.Indented);
            File.WriteAllText(saveFilePath, jsonData);

            LoadGame();
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al guardar los datos: " + e.Message);
        }

    }

   

    public void FirstGameStart()
    {
        SetInitialStatsNewGame();

        Invoke("GoToGameplayScene", 1.0f);
    }

    public void SetInitialStatsNewGame()
    {
        try
        {
            PlayerData playerData = new PlayerData
            {
                companyName = ChooseNameLogic.nameString,
                hasPlayedBefore = false,
                playerStats = new PlayerStats
                {
                    day = 1,
                    money = INITIALMONEY
                },
                settings = new Settings
                {
                    isMusicActive = AudioManagement.isMusicOn,
                    isFxActive = AudioManagement.isFxOn
                },
                upgrades = new Upgrades
                {
                    quantityNewsLevel = 0,
                    freeNewsLevel = 0,
                    moreImpressionsLevel = 0
                }
            };

            string jsonData = JsonConvert.SerializeObject(playerData, Formatting.Indented);
            File.WriteAllText(saveFilePath, jsonData);

            LoadGame();
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al guardar los datos: " + e.Message);
        }
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
                hasPlayedBefore = hasPlayed,
                playerStats = new PlayerStats
                {
                    day = RandomInterests.dayCount,
                    money = MoneyLogic.totalMoney
                },
                settings = new Settings
                {
                    isMusicActive = AudioManagement.isMusicOn,
                    isFxActive = AudioManagement.isFxOn
                },
                upgrades = new Upgrades
                {
                    quantityNewsLevel = UpgradesLogic.quantityLevel,
                    freeNewsLevel = UpgradesLogic.freeLevel,
                    moreImpressionsLevel = UpgradesLogic.impressionsLevel
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
            hasPlayed = playerData.hasPlayedBefore;

            // Load Gameplay Logic
            RandomInterests.dayCount = playerData.playerStats.day;
            MoneyLogic.totalMoney = playerData.playerStats.money;
            AudioManagement.isMusicOn = playerData.settings.isMusicActive;
            AudioManagement.isFxOn = playerData.settings.isFxActive;
            AudioManagement.lastVolumeMusic = playerData.settings.startMusicVolume;
            AudioManagement.lastVolumeFX = playerData.settings.startFxVolume;

            // Load Upgrades
            UpgradesLogic.quantityLevel = playerData.upgrades.quantityNewsLevel;
            UpgradesLogic.freeLevel = playerData.upgrades.freeNewsLevel;
            UpgradesLogic.impressionsLevel = playerData.upgrades.moreImpressionsLevel;

            // Checkers LOGS
            Debug.Log("HAS PLAYED BEFORE: " + hasPlayed);

            Debug.Log("Loaded company name: " + ChooseNameLogic.nameString);
            Debug.Log("Loaded day count: " + RandomInterests.dayCount);
            Debug.Log("Loaded total money: " + MoneyLogic.totalMoney);
            Debug.Log("Loaded music active: " + AudioManagement.isMusicOn);
            Debug.Log("Loaded fx active: " + AudioManagement.isFxOn);

            Debug.Log("Quantity Level: " + UpgradesLogic.quantityLevel);
            Debug.Log("Free News Level: " + UpgradesLogic.freeLevel);
            Debug.Log("Impressions Level: " + UpgradesLogic.impressionsLevel);

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
        public bool hasPlayedBefore;

        public PlayerStats playerStats;
        public Settings settings;
        public Upgrades upgrades;
    }

    public class PlayerStats
    {
        public int day;
        public double money;
    }

    public class Settings
    {
        public bool isMusicActive;
        public bool isFxActive;

        public float startMusicVolume;
        public float startFxVolume;
    }

    public class Upgrades
    {
        public int quantityNewsLevel;
        public int freeNewsLevel;
        public int moreImpressionsLevel;
    }
}
