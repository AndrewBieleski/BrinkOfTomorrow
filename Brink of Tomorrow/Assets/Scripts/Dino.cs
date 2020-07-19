using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : Interactable
{

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        //TODO: generate timeloop object???

        //TODO: set dino objective to true
    }
}
