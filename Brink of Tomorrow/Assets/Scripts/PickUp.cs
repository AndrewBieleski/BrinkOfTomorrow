using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : Interactable
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Pickup(Inventory playerInv)
    {
        playerInv.PickUpObject(transform.gameObject);
        bc.gameObject.SetActive(false);
        sr.gameObject.SetActive(false);
    }

    public void Drop(Vector3 position, Inventory playerInv)
    {
        playerInv.DropObject();
        bc.gameObject.SetActive(true);
        sr.gameObject.SetActive(true);
        transform.position = position;
    }
}
