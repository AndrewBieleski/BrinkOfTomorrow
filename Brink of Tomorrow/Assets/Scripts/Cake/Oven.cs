using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : Interactable {

    public Inventory inventory;

    //Three ingredients the oven needs
    public List<string> requiredIngredients;

    public bool isBaking = false;
    public Cake cake;

    // Start is called before the first frame update
    void Start()
    {
        requiredIngredients = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBaking && cake != null) {
            cake.Cook();
        }
    }

    override public void Interact()
    {
        if (isBaking && cake != null) {
            if (inventory.PickUpObject(cake.gameObject)) {
                cake = null;
            }
        }
        else if (isBaking && inventory.heldObject.GetComponent<Cake>()) {
            cake = inventory.GetComponent<Cake>();
        }
        else if (inventory.heldObject != null && inventory.heldObject.GetComponent<Ingredients>() != null && requiredIngredients.Contains(inventory.heldObject.GetComponent<Ingredients>().ingredientType) ){
            requiredIngredients.Remove(inventory.heldObject.GetComponent<Ingredients>().ingredientType);
            GameObject currentIngredient = inventory.DropObject();
            if (requiredIngredients.Count == 0) {
                isBaking = true;
                cake = new Cake();
            }          
        }
    }
}
