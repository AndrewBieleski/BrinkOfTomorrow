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
			dog.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100, -100));
			dog.GetComponent<Rigidbody2D>().AddTorque(10f);
			return false;
		} else {
			return true;
		}
	}

}
