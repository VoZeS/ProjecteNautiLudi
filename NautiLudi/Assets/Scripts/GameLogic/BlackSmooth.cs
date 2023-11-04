using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackSmooth : MonoBehaviour
{
    // To Invisible
    private Image[] targetImage; 
    private float targetAlpha;

    private Color[] originalColor;
    private Color[] targetColor;
    private bool isFading = false;
    private float timer = 0.0f;

    public float fadeDuration = 1.0f;

    // To Visible (2)
    private Image[] targetImage2;
    private float targetAlpha2;

    private Color[] originalColor2;
    private Color[] targetColor2;
    private bool isFading2 = false;
    private float timer2 = 0.0f;

    void Update()
    {
        if (isFading)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / fadeDuration);

            for (int i = 0; i < targetImage.Length; i++)
            {
                targetImage[i].color = Color.Lerp(originalColor[i], targetColor[i], t);
            }

            if (t >= 1.0f)
            {
                isFading = false;
            }
        }
        if (isFading2)
        {
            timer2 += Time.deltaTime;
            float t = Mathf.Clamp01(timer2 / fadeDuration);

            for (int i = 0; i < targetImage2.Length; i++)
            {
                targetImage2[i].color = Color.Lerp(originalColor2[i], targetColor2[i], t);
            }

            if (t >= 1.0f)
            {
                isFading2 = false;
            }
        }
    }

    public void StartToInvisibleFading(Image[] image)
    {
        isFading = true;
        targetAlpha = 0.0f;
        targetImage = image;
        originalColor = new Color[targetImage.Length];
        targetColor = new Color[targetImage.Length];

        for (int i = 0; i < targetImage.Length; i++)
        {
            originalColor[i] = targetImage[i].color;
            targetColor[i] = new Color(originalColor[i].r, originalColor[i].g, originalColor[i].b, targetAlpha);
        }
        timer = 0.0f;
    }

    public void StartToVisibleFading(Image[] image)
    {
        isFading2 = true;
        targetAlpha2 = 1.0f;
        targetImage2 = image;
        originalColor2 = new Color[targetImage2.Length];
        targetColor2 = new Color[targetImage2.Length];

        for (int i = 0; i < targetImage2.Length; i++)
        {
            originalColor2[i] = targetImage2[i].color;
            targetColor2[i] = new Color(originalColor2[i].r, originalColor2[i].g, originalColor2[i].b, targetAlpha2);
        }

        timer2 = 0.0f;
    }
}
