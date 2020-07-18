using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : Interactable
{
    public Dialogue targetDialogue;

    public override void Interact()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(targetDialogue, this);
    }
}
