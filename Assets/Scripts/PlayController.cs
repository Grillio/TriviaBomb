using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    public GameObject MatchChoiceCanvas;
    public GameObject PublicPrivateCanvas;

    private bool PublicGame;

    public ButtonController ButtonController;

    private void Start()
    {
        MatchChoiceCanvas.SetActive(false);
        PublicPrivateCanvas.SetActive(false);
    }

    public void ChoosePublic()
    {
        ButtonController.further = true;
        PublicGame = true;
        MatchChoiceCanvas.SetActive(true);
        PublicPrivateCanvas.SetActive(false);
    }

    public void ChoosePrivate()
    {
        ButtonController.further = true;
        PublicGame = false;
        MatchChoiceCanvas.SetActive(true);
        PublicPrivateCanvas.SetActive(false);
    }

    public void GoBack()
    {
        if (!ButtonController.further)
        {
            PublicPrivateCanvas.SetActive(false);
        }
        else
        {
            PublicPrivateCanvas.SetActive(true);
        }
        ButtonController.further = false;
        MatchChoiceCanvas.SetActive(false);
    }




}
