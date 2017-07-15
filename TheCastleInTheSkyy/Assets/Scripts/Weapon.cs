using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    Stack<Scrap> ammo; // ammo for the weapon

	// Use this for initialization
	void Start () {
        ammo = new Stack<Scrap>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    Scrap Shoot()
    {
        return ammo.Pop();
    }

    void Reload()
    {
        if (ammo.Count <= 0)
            ammo.Push(new Scrap());
    }
}
