using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    float _timer;
    void Awake ()
    {
        _timer = 120;
        timerText.text = _timer.ToString();
    }

    void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;           
        }
        timerText.text = _timer.ToString();

        if (_timer == 0)
        {
            SceneManager.LoadScene("Level 2");
        }
        DisplayTime(_timer);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float secondes = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, secondes);
    }
}
