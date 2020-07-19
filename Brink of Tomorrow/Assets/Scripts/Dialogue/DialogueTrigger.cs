using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : Interactable
{
    public Dialogue targetDialogue;
    public bool doneTalking = false;

    public override void Interact()
    {
        if (!doneTalking)
            FindObjectOfType<DialogueManager>().StartDialogue(targetDialogue, this);
    }
}
