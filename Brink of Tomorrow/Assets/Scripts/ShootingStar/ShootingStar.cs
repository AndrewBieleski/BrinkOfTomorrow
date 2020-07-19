using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public CharacterController player;
    public TimeSave starObjective;
    public Collider2D targetArea;
    public GameObject objective;

    private void Awake()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(600, 800));
    }

    private void Update()
    {
        if (targetArea.IsTouching(player.GetComponent<Collider2D>())){
            //Play Shooting Star Animation
            starObjective.SawAStar = true;
            objective.SetActive(true);
        } 
    }
}
