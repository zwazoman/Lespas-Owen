using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject switchMenu;
    [SerializeField] GameObject hudPanel;
    [SerializeField] GameObject deathPanel;

    public void SelectMenu()
    {
        EventSystem.current.SetSelectedGameObject(switchMenu);
    }

    public void DontShowHud () 
    {
   // if  (deathPanel.isActive) 
        { 
            hudPanel.SetActive(false);
        }
    }
}
