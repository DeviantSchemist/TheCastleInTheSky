using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : Civilian {

    private Weapon myWeapon;

	// Use this for initialization
	void Start () {
        myWeapon = new Weapon();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
