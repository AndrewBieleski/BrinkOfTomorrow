using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //vars
    public float activationRadius = 1.0f;
    public bool inInteractZone = false;
    public bool inPickupZone = false;
   
    //refs
    public BoxCollider2D bc;
    public Inventory playerInv;
    public GameObject currentInteractable;
    public GameObject currentPickup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //if interacting with interactable -> interact
        if (inInteractZone && MouseCheck(currentInteractable) && Input.GetKeyDown(KeyCode.E))
        {
            currentInteractable.GetComponent<Interactable>().Interact();
        }
        //if picking up new object -> drop old object, pick up new object
        else if (!inInteractZone && inPickupZone && MouseCheck(currentPickup) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (playerInv.heldObject) playerInv.heldObject.GetComponent<PickUp>().Drop(GetMousePoint(), playerInv);
            currentPickup.GetComponent<PickUp>().Pickup(playerInv);
        }
        //if not in interact zone or pickup zone, drop old object if one exists
        else if (!inInteractZone && !inPickupZone && Input.GetKeyDown(KeyCode.E) && PlayerMouseCheck())
        {
            if (playerInv.heldObject) playerInv.heldObject.GetComponent<PickUp>().Drop(GetMousePoint(), playerInv);
        }
    }

    public Vector3 GetMousePoint()
    {
        Vector3 wmp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return new Vector3(wmp.x, wmp.y, 0);
    }

    public bool PlayerMouseCheck()
    {
        Vector3 mp = Input.mousePosition;
        Vector3 wmp = Camera.main.ScreenToWorldPoint(mp);
        Vector2 position = Vector2.zero;
        position.x = wmp.x;
        position.y = wmp.y;

        Vector2 distance = Vector2.zero;
        distance.x = this.transform.position.x - position.x;
        distance.y = this.transform.position.y - position.y;
        Debug.Log(distance.magnitude);
        if (distance.magnitude < activationRadius * 2.5) {
            return true;
        }
        return false;
    }

    public bool MouseCheck(GameObject interactable)
    {
        if (interactable)
        {
            Vector3 mp = Input.mousePosition;
            Vector3 wmp = Camera.main.ScreenToWorldPoint(mp);
            Vector2 position = Vector2.zero;
            position.x = wmp.x;
            position.y = wmp.y;

            Vector2 distance = Vector2.zero;
            distance.x = interactable.transform.position.x - position.x;
            distance.y = interactable.transform.position.y - position.y;

            if (distance.magnitude < activationRadius)
            {
                return true;
            }
        }
        return false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            inPickupZone = true;
            currentPickup = other.gameObject;
        }
        else if (other.gameObject.CompareTag("Interactable"))
        {
            inInteractZone = true;
            currentInteractable = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            //TODO: make smart
            inPickupZone = false;
            currentPickup = null;
        }
        else if (other.gameObject.CompareTag("Interactable"))
        {
            //TODO: make smart
            inInteractZone = false;
            currentInteractable = null;
        }
    }
}
