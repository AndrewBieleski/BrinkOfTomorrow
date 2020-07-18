using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : PickUp
{

    public float cookingTime = 100f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cook()
    {
        cookingTime--;
    }
}
