using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : Upgrade
{
    
    private void ApplyUpgrade(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.parent.GetComponentInChildren<CharacterController>().hasJetpack = true;
            Destroy(this.gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        this.ApplyUpgrade(other);
    }
}
