using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLoop : MonoBehaviour
{

    public TimeSave timeSave;

    void Start()
    {
        TimeClock.currentTime = 0f;
    }

    void Update()
    {
        TimeClock.currentTime += Time.deltaTime;
        if (TimeClock.currentTime > TimeClock.maxTime) {
            ResetTime();
        }        
    }

    void ResetTime()
    {
        timeSave.SaveCurrentState();
        //Load into scene 1, we start in scene 0 with low time left)
        SceneManager.LoadScene(1);
    }
}
