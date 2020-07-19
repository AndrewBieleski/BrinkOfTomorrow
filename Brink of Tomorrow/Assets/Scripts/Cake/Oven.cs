using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : Interactable {

    public Inventory inventory;

    //Three ingredients the oven needs
    public List<string> requiredIngredients = new List<string>();

    public bool isBaking = false;
    public Cake cake;
    public GameObject cakePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
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
                cakePrefab.SetActive(true);
                cake = cakePrefab.GetComponent<Cake>();
            }          
        }
    }
}
