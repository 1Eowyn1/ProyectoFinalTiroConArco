using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Timer timerScript;
    public GameObject targets;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Go_game();
    }

    public void Go_game()
    {
        timerScript.SetRunning();
    }

    public void HideTargerts()
    {
        targets.SetActive(false);
    }
}
