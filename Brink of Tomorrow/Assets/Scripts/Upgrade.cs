using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public BoxCollider2D bc;

    private void ApplyUpgrade(Collider2D other)
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        ApplyUpgrade(other);
    }
}