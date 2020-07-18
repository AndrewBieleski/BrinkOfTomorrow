using System;
using UnityEngine;

public class DogWaypoint : MonoBehaviour
{

	public Transform position;
	public bool dangerous;

	private void Start()
	{
		this.position = GetComponent<Transform>();
	}

	public virtual bool arrived()
	{
		return !dangerous;
	}
}