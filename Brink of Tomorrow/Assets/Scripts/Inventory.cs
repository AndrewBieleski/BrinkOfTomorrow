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

    public void PickUpObject(GameObject pickupObject)
    {
        heldObject = pickupObject;
    }

    public void DropObject()
    {
        heldObject = null;
    }
}
