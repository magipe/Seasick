﻿using UnityEngine;
using System.Collections;

public class Job : MonoBehaviour {

	public double effect;

	public bool affectsFood = false;
	public bool affectsWater = false;
	public bool affectsWood = false;

	void Start () {
	
	}

	void Update () {

	}

	public void doAffect() {
		if (affectsFood) {
			JobManager.setFood(effect);
			PirateManager.setHunger(effect);
		}
		else if (affectsWater) {
			JobManager.setWater(effect);
			PirateManager.setThirst(effect);
		}
		else if (affectsWood) 
			JobManager.setWood(effect);
		PirateManager.calculateTotals ();
	}
}
