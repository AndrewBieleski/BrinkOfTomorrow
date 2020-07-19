using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogTarget : DogWaypoint
{

	public TimeSave objective;

	public override bool arrived()
	{
		objective.SavedPuppy = true;
		return true;
	}

}
