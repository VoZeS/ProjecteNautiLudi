using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButtonLogic : MonoBehaviour
{
    public GameObject continueButton;
    public void ActivateContinueButton()
    {
        if (GameManagement.hasPlayed)
            continueButton.SetActive(true);
        else if (!GameManagement.hasPlayed)
            continueButton.SetActive(false);

    }
}
