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

    [Header("Selection Button")]
    public Image[] selectionButtonBackground;
    public TMP_Text[] selectionButtonText;

    [Header("Associate Button")]
    public Image[] associateButtonBackground;
    public TMP_Text[] associateButtonText;

    public Transform startTarget;

    void Start()
    {
        panelImage = GetComponent<Image>();
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

            if (t >= 1.0f)
            {
                isFadingToBlack = false;
                if (targetAlpha == 1.0f) // Fade in completed
                {
                    // New Day Logic
                    NewDayLogic();

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
