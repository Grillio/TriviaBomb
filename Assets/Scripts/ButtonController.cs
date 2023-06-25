using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject BackButton;

    public List<GameObject> Tabs;

    private GameObject currentTab;

    public List<GameObject> Canvases;

    public bool further;

    private void Start()
    {
        BackButton.SetActive(false);
        SetCanvasesFalse();
        further = false;
    }

    public void ClickedPlay(GameObject _play)
    {
        OpenTab(_play);
        Canvases[0].SetActive(true);
    }

    public void ClickedShop(GameObject _shop)
    {
        OpenTab(_shop);
    }

    public void ClickedRewards(GameObject _rewards)
    {
        OpenTab(_rewards);
    }

    public void ClickedLeaderboards(GameObject _leaders)
    {
        OpenTab(_leaders);
    }

    public void ClickedProfile(GameObject _profile)
    {
        OpenTab(_profile);
    }

    public void ClickedBackButton()
    {
        if (!further)
        {
            CloseTab();
        }
    }

    private void SetCanvasesFalse()
    {
        foreach (GameObject _canvases in Canvases)
        {
            _canvases.SetActive(false);
        }
    }

    private void OpenTab(GameObject _tab)
    {
        if(currentTab != _tab)
        foreach (var tab in Tabs)
        {
            if(tab != _tab)
            {
                    tab.GetComponent<Button>().enabled = false;
                tab.GetComponent<Animator>().SetTrigger("Dock");
            }
                else
                {
                    tab.GetComponent<Animator>().SetTrigger("Select");
                }
        }
        currentTab = _tab;
        BackButton.SetActive(true);
        
    }

    private void CloseTab()
    {
        SetCanvasesFalse();
        foreach (var tab in Tabs)
        {
            if (tab != currentTab)
            {
                tab.GetComponent<Button>().enabled = true;
                tab.GetComponent<Animator>().SetTrigger("Undock");
            }
            else
            {
                tab.GetComponent<Animator>().SetTrigger("Unselect");
            }
        }
        currentTab = null;

        BackButton.SetActive(false);
    }
}
