using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackSmooth : MonoBehaviour
{
    private Image targetImage; 
    public float fadeDuration = 1.0f; 
    private float targetAlpha;

    private Color originalColor;
    private Color targetColor;
    private bool isFading = false;
    private float timer = 0.0f;

    void Start()
    {
        originalColor = targetImage.color;
    }

    void Update()
    {
        if (isFading)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / fadeDuration);
            targetImage.color = Color.Lerp(originalColor, targetColor, t);

            if (t >= 1.0f)
            {
                isFading = false;
            }
        }
    }

    public void StartToInvisibleFading(Image image)
    {
        isFading = true;
        targetAlpha = 0.0f;
        targetColor = new Color(originalColor.r, originalColor.g, originalColor.b, targetAlpha);
        targetImage = image;
        timer = 0.0f;
    }

    public void StartToVisibleFading(Image image)
    {
        isFading = true;
        targetAlpha = 1.0f;
        targetColor = new Color(originalColor.r, originalColor.g, originalColor.b, targetAlpha);
        targetImage = image;
        timer = 0.0f;
    }
}
