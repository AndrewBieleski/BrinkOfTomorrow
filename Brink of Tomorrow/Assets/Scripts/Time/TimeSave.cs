using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSave : MonoBehaviour
{
	public bool ShootingStarObjective = false;
	public GameObject shootingStarUncomplete;
	public GameObject shootingStarComplete;

	public bool CakeObjective = false;
	public bool PatADinosaur = false;
	public bool SavePuppy = false;
	public bool FindLove = false;
	public bool SaveStation = false;

	//Contains all the variables we want to save between levels
	private void Start()
	{
		//Set objectives
		shootingStarUncomplete.SetActive(!ShootingStarObjective);
		shootingStarComplete.SetActive(ShootingStarObjective);
	}

	public void SaveCurrentState()
	{
		DontDestroyOnLoad(this);
	}
}
