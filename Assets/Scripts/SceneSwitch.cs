using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void GoPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Leave()
    {
        Application.Quit();
        Debug.Log("Quitté");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
