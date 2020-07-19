using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : PickUp
{

    public float cookingTime = 500.00f;
    public TMPro.TextMeshProUGUI countdown;
    public GameObject hud;
    public bool cooking = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        hud.SetActive(cooking);
        TimeSpan timeSpan = TimeSpan.FromSeconds(cookingTime);
        countdown.text = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
    }

    public void Cook()
    {
        cooking = true;
        cookingTime -= Time.deltaTime;
    }
}
