using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public TextMeshPro timeText;
    public StartGame startGameScript;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                startGameScript.HideTargerts();
            }
        }
    }

    public void SetRunning()
    {
        timerIsRunning=true;
    }

    public void StopTimer()
    {
        timerIsRunning = false;
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutos = Mathf.FloorToInt(timeToDisplay / 60);
        float segundos = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Time: " + string.Format("{1:00}", minutos, segundos);
    }
}
