using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour
{
    public BlackSmooth fadingScript;

    [Header("StartImages")]
    public Image[] startImages;

    [Header("RedactImages")]
    public Image[] redactImages;

    [Header("UpgradesImages")]
    public Image[] upgradesImages;

    [Header("WinLoseImages")]
    public Image[] winloseImages;

    [Header("Write Button")]
    public GameObject writeNewspaper;
    public GameObject newsScroll;

    private void Update()
    {
        if(NewsLogic.selectedNews >= 3 && newsScroll.activeInHierarchy)
        {
            writeNewspaper.SetActive(true);
        }
        else if(NewsLogic.selectedNews < 3 || !newsScroll.activeInHierarchy)
        {
            writeNewspaper.SetActive(false);
        }
    }

    public void Start_InvisibleFading()
    {
        fadingScript.StartToInvisibleFading(startImages);
    }

    public void Start_VisibleFading()
    {
        fadingScript.StartToVisibleFading(startImages);
    }
    public void Redact_InvisibleFading()
    {
        fadingScript.StartToInvisibleFading(redactImages);
    }

    public void Redact_VisibleFading()
    {
        fadingScript.StartToVisibleFading(redactImages);
    }
    public void Upgrades_InvisibleFading()
    {
        fadingScript.StartToInvisibleFading(upgradesImages);
    }

    public void Upgrades_VisibleFading()
    {
        fadingScript.StartToVisibleFading(upgradesImages);
    }
    public void WinLose_InvisibleFading()
    {
        fadingScript.StartToInvisibleFading(winloseImages);
    }

    public void WinLose_VisibleFading()
    {
        fadingScript.StartToVisibleFading(winloseImages);
    }

}
