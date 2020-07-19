using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fail : Dialogue
{

	public DialogueTrigger originalDialogue;

	public override void DialogueEvent()
	{
		originalDialogue.doneTalking = true;
	}

}
