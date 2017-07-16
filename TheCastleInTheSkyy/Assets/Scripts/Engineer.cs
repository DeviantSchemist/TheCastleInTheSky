using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer : Civilian {

	// Main onstructor 
	public Engineer(){
		weight = 1;
		decayRate = 4;
		unitType = 2;
		decay = false;
		lifeSpan = 0;
	}
		
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		unitDecay();
	}

   
}

//	int getEngAmount(){
//		return engAmount;
//	}
//
//	bool engCheck(){
//		return becomeEng;
//	}

// Previous start version 
//// Use this for initialization
//void Start () {
//	engTime = 6f;
//	becomeEng = false;
//}


// Previous update version 
//void Update () {
//	engTime -= Time.deltaTime;
//	if (engTime < 0)
//	{
//		becomeEng = true;
//	}
//}