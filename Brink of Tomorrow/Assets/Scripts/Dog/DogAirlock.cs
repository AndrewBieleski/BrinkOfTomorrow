using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAirlock : DogWaypoint
{

	public bool Switch = true;
	public DogPatrol dog;
	public Vector2 direction;

	public override bool arrived()
	{
		if (Switch) {
			dog.GetComponent<Rigidbody2D>().AddForce(direction);
			dog.GetComponent<Rigidbody2D>().AddTorque(15f);
			return false;
		} else {
			return true;
		}
	}

}
