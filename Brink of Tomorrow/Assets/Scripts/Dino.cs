using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : Interactable
{

    public TimeSave objective;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public override void Interact()
    {
        objective.PatADinosaur = true;
    }
}
