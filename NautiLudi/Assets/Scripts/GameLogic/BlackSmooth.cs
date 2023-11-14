using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackSmooth : MonoBehaviour
{
    // To Invisible
    private Renderer targetImage; 
    private float targetAlpha;

    private Color originalColor;
    private Color targetColor;
    private bool isFading = false;
    private float timer = 0.0f;

    public float fadeDuration = 1.0f;

    // To Visible (2)
    private Renderer targetImage2;
    private float targetAlpha2;

    private Color originalColor2;
    private Color targetColor2;
    private bool isFading2 = false;
    private float timer2 = 0.0f;

    void Update()
    {
        if (isFading)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / fadeDuration);

            targetImage.material.color = Color.Lerp(originalColor, targetColor, t);

            if (t >= 1.0f)
            {
                isFading = false;
            }
        }
        if (isFading2)
        {
            timer2 += Time.deltaTime;
            float t = Mathf.Clamp01(timer2 / fadeDuration);

            targetImage2.material.color = Color.Lerp(originalColor2, targetColor2, t);

            if (t >= 1.0f)
            {
                isFading2 = false;
            }
        }
    }

    public void StartToInvisibleFading(Renderer image)
    {
        isFading = true;
        targetAlpha = 0.0f;
        targetImage = image;
        originalColor = new Color();
        targetColor = new Color();

        originalColor = targetImage.material.color;
        targetColor = new Color(originalColor.r, originalColor.g, originalColor.b, targetAlpha);
        
        timer = 0.0f;
    }

    public void StartToVisibleFading(Renderer image)
    {
        isFading2 = true;
        targetAlpha2 = 1.0f;
        targetImage2 = image;
        originalColor2 = new Color();
        targetColor2 = new Color();

        originalColor2 = targetImage2.material.color;
        targetColor2 = new Color(originalColor2.r, originalColor2.g, originalColor2.b, targetAlpha2);
        
        timer2 = 0.0f;
    }

}
