using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //variables

    //references
    public GameObject heldObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool PickUpObject(GameObject pickupObject)
    {
        if (heldObject = null) {
            heldObject = pickupObject;
            return true;
        }
        return false;
    }

    public GameObject DropObject()
    {
        GameObject droppedObject = heldObject;
        heldObject = null;
        return droppedObject;
    }
}
