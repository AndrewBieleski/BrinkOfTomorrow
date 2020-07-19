using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Success : Dialogue
{

	public TimeSave objective;

	public override void DialogueEvent()
	{
		objective.FindLove = true;
	}

}
