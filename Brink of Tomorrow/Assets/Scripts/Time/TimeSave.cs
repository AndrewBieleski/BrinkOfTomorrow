using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSave : MonoBehaviour
{

	//public GameObject shootingStarUncomplete;
	//public GameObject shootingStarComplete;

	public bool SawAStar = false;
	public bool BakedACake = false;
	public bool SavedPuppy = false;
	public bool FindLove = false;
	public bool PatADinosaur = false;
	public bool SaveStation = false;

	public GameObject cakeObjective;
	public GameObject dinoObjective;
	public GameObject puppyObjective;
	public GameObject loveObjective;
	public GameObject shootingObjective;
	public GameObject stationObjective;

	//Contains all the variables we want to save between levels
	void Update()
	{
		//Set objectives
		cakeObjective.SetActive(BakedACake);
		dinoObjective.SetActive(PatADinosaur);
		puppyObjective.SetActive(SavedPuppy);
		loveObjective.SetActive(FindLove);
		shootingObjective.SetActive(SawAStar);
		stationObjective.SetActive(SaveStation);
	}

	public void SaveCurrentState()
	{
		DontDestroyOnLoad(this);
	}
}
