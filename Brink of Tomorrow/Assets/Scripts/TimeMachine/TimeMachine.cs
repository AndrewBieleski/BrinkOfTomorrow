using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachine : Interactable
{

    public Inventory inventory;
    public TimeSave objective;

    //Three ingredients the oven needs
    public PickUp missingPart;
    public Sprite fixedSprite;

    public bool fixedMachine = false;

    override public void Interact()
    {
        if (!fixedMachine && inventory.heldObject.GetComponentInChildren<PickUp>() is Gear) {
            this.GetComponent<SpriteRenderer>().sprite = fixedSprite;
            fixedMachine = true;
            inventory.heldObject = null;
            objective.SaveStation = true;
        }
    }

}
