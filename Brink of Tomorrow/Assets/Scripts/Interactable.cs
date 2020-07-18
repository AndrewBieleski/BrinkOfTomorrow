using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    //variables
    public bool runThisFrame = false;
    public bool interactable = false;

    //references
    public BoxCollider2D bc;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("TEST");
    }

    virtual public void Interact()
    {
        Debug.Log("interacted");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.gameObject.CompareTag("Player")) interactable = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.gameObject.CompareTag("Player")) interactable = false;
    }
}
