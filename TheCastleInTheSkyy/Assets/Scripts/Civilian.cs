using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Civilian : MonoBehaviour {

	protected float decayRate;			// This is the rate the decay rate that determines when a unit becomes scrap 
	protected float weight;				// Weight of the unit 
	protected int unitType;				// Unit tyoe is associated with a number 

	// Main constructor 
	public Civilian() {
		decayRate = 10;
		weight = 1;
		unitType = 1;
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


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
