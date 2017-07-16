using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Civilian {

	protected float decayRate;			// This is the rate the decay rate that determines when a unit becomes scrap 
	protected float weight;				// Weight of the unit 
	protected int unitType;				// Unit tyoe is associated with a number 
	protected bool decay;
	protected float lifeSpan;

	// Main constructor 
	public Civilian() {
		decayRate = 7;
		weight = 1;
		unitType = 1;
		decay = false;
		lifeSpan = 0;
	}

	//how fast each class ages
	public void aging(){
		
	}

	// Getter function for citizens 
	public float getWeight(){
		return weight;
	}

	// Getter function for unit type 
	public int getUnitType(){
		return unitType;
	}

	// This function will be run every frame in the update function 
	public bool unitDecay(){
		lifeSpan++;
		if (lifeSpan >= (50 * decayRate)) {
			decay = true;
		} else {
			decay = false;
		}
		return decay;
	}


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		unitDecay();
	}

   
}
