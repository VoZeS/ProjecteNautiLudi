using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{
    public float fadeDuration = 1.0f;
    private float targetAlpha;
    private float actualAlpha;
    private Image panelImage;
    private bool isFadingToBlack = false;
    private float timer = 0.0f;

    public CameraMovement cam;
    public ButtonLogic buttonScript;
    public RandomInterests interestScript;
    public GameObject bottomBackgroundUI;

    [Header("Selection Button")]
    public Image[] selectionButtonBackground;
    public TMP_Text[] selectionButtonText;

    [Header("Associate Button")]
    public Image[] associateButtonBackground;
    public TMP_Text[] associateButtonText;

    public Transform startTarget;

    [Header("Lose Screen")]
    public GameObject loseScreen;
    public GameManagement managerScript;

    public AudioSource nightTime;
    public AudioSource dayTime;

    void Start()
    {
        panelImage = GetComponent<Image>();

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
    }

    void Update()
    {
        if (isFadingToBlack)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / fadeDuration);
            Color newColor = panelImage.color;
            newColor.a = Mathf.Lerp(actualAlpha, targetAlpha, t);
            panelImage.color = newColor;
            nightTime.Play();

            if (t >= 1.0f)
            {
                isFadingToBlack = false;
                if (targetAlpha == 1.0f) // Fade in completed
                {
                    bottomBackgroundUI.SetActive(true);

                    if (WinLoseManager.hasLost)
                    {
                        loseScreen.SetActive(true);
                        ResetNews();
                        GameManagement.hasPlayed = false;

                        if(managerScript != null)
                            managerScript.SaveGame();

                        Debug.Log(GameManagement.hasPlayed);
                    }
                    else if(!WinLoseManager.hasLost)
                    {
                        // New Day Logic
                        NewDayLogic();
                        loseScreen.SetActive(false);

                    }

                }
                else if (targetAlpha == 0.0f) // Fade out completed
                {
                    isFadingToBlack = false;
                    gameObject.SetActive(false);

                }
            }
        }
    }

    private void NewDayLogic()
    {
        cam.MoveCamera(startTarget);
        cam.SetEnd(false);

        Invoke("StartFadeFromBlack", 2.0f);

        buttonScript.WinLose_VisibleFading();
        interestScript.SetNewDay();

        nightTime.Stop();
        //dayTime.Play();

        ResetNews();
    }

    private void ResetNews()
    {
        NewsLogic.newsSelectedList.Clear();

        for (int i = 0; i < selectionButtonText.Length; i++)
        {
            selectionButtonText[i].text = "Seleccionar";
            selectionButtonBackground[i].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1);
        }

        for (int i = 0; i < associateButtonText.Length; i++)
        {
            associateButtonText[i].text = "Seleccionar";
            associateButtonBackground[i].color = new Color(60f / 255f, 180f / 255f, 70f / 255f, 1);
        }
    }

    public void StartFadeToBlack()
    {
        isFadingToBlack = true;
        targetAlpha = 1.0f;
        actualAlpha = 0.0f;
        timer = 0.0f;
    }

    public void StartFadeFromBlack()
    {
        isFadingToBlack = true;
        actualAlpha = 1.0f;
        targetAlpha = 0.0f;
        timer = 0.0f;
    }
}
