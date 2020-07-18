using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAirlock : DogWaypoint
{

	public bool Switch = true;
	public DogPatrol dog;

	public override bool arrived()
	{
		if (Switch) {
			Debug.Log("TEST");
			dog.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000, -1000));
			return false;
		} else {
			return true;
		}
	}

}
