using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseManager : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0.0f;
    }

    public void StartGamme()
    {
        Time.timeScale = 1.0f;
    }
}
