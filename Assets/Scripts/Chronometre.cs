using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chronometre : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    float _timer;
    void Awake()
    {
        _timer = 0;
        timerText.text = _timer.ToString();
    }

    void Update()
    {
        _timer += Time.deltaTime;
        timerText.text = _timer.ToString();
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
