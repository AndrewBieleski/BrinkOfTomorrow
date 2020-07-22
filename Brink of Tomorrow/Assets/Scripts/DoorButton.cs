using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : Interactable
{
    //vars
    public bool open = false;

    public DogAirlock door;

    //refs
    public List<GameObject> doorObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {

        door.Switch = false;

        foreach (GameObject door in doorObjects)
        {
            door.SetActive(open);
        }
     open = !open;
    }
}
