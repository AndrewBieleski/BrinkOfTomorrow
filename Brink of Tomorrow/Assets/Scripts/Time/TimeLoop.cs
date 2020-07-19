using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLoop : MonoBehaviour
{

    public TimeSave timeSave;
    public TMPro.TextMeshProUGUI countdown;

    public int maxTimeSeconds = 300;

    void Start()
    {
        TimeClock.currentTime = maxTimeSeconds;
    }

    void Update()
    {
        TimeClock.currentTime -= Time.deltaTime;
        TimeSpan timeSpan = TimeSpan.FromSeconds(TimeClock.currentTime);
        countdown.text = string.Format("{0:D2}:{1:D2}:{2:}", timeSpan.Minutes, timeSpan.Seconds, (timeSpan.Milliseconds % 10000) / 10);
        if (TimeClock.currentTime < 0) {
            ResetTime();
        }
    }

    void ResetTime()
    {
        timeSave.SaveCurrentState();
        //Load into scene 1, we start in scene 0 with low time left)
        SceneManager.LoadScene(0);
    }
}
