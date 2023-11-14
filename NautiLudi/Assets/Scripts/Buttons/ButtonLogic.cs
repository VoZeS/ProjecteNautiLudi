using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour
{
    public BlackSmooth fadingScript;

    [Header("StartImages")]
    public Renderer startRender;

    [Header("RedactImages")]
    public Renderer redactRender;

    [Header("UpgradesImages")]
    public Renderer upgradesRender;

    [Header("WinLoseImages")]
    public Renderer winloseRender;

    [Header("Write Button")]
    public GameObject writeNewspaper;
    public GameObject newsScroll;
    public GameObject PC_writeNewspaper;
    public GameObject PC_newsScroll;

    private void Update()
    {
        if(UIDisplay.isPC)
        {
            if (NewsLogic.selectedNews >= 3 && PC_newsScroll.activeInHierarchy)
            {
                PC_writeNewspaper.SetActive(true);
            }
            else if (NewsLogic.selectedNews < 3 || !PC_newsScroll.activeInHierarchy)
            {
                PC_writeNewspaper.SetActive(false);
            }
        }
        else
        {
            if (NewsLogic.selectedNews >= 3 && newsScroll.activeInHierarchy)
            {
                writeNewspaper.SetActive(true);
            }
            else if (NewsLogic.selectedNews < 3 || !newsScroll.activeInHierarchy)
            {
                writeNewspaper.SetActive(false);
            }
        }
        
    }
    public void Start_InvisibleFading()
    {
        fadingScript.StartToInvisibleFading(startRender);
    }

    public void Start_VisibleFading()
    {
        fadingScript.StartToVisibleFading(startRender);
    }
    public void Redact_InvisibleFading()
    {
        fadingScript.StartToInvisibleFading(redactRender);
    }

    public void Redact_VisibleFading()
    {
        fadingScript.StartToVisibleFading(redactRender);
    }
    public void Upgrades_InvisibleFading()
    {
        fadingScript.StartToInvisibleFading(upgradesRender);
    }

    public void Upgrades_VisibleFading()
    {
        fadingScript.StartToVisibleFading(upgradesRender);
    }
    public void WinLose_InvisibleFading()
    {
        fadingScript.StartToInvisibleFading(winloseRender);
    }

    public void WinLose_VisibleFading()
    {
        fadingScript.StartToVisibleFading(winloseRender);
    }

}
