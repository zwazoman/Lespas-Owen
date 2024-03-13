using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject switchMenu;
    public void SelectMenu()
    {
        EventSystem.current.SetSelectedGameObject(switchMenu);
    }
}
