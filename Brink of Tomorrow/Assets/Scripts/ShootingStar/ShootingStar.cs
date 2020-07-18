using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public CharacterController player;
    public GameObject ShootingStarUncomplete;
    public GameObject ShootingStarComplete;

    private void Update()
    {
        if (TimeClock.currentTime > TimeClock.StarTime && this.GetComponent<Collider2D>().IsTouching(player.GetComponent<Collider2D>())){
            //Play Shooting Star Animation
            GetComponent<TimeSave>().SawAStar = true;
        } 
    }
}
