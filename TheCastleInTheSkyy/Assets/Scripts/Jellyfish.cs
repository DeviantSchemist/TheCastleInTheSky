using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jellyfish : MonoBehaviour {

    private const float JELLY_WEIGHT = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void onCollisionEnter(Collision2D collision)
    {
        if (collision.gameObject.tag == "Civilian" || collision.gameObject.tag == "Soldier" || collision.gameObject.tag == "Engineer"
            || collision.gameObject.tag == "Ship")
        {
            Destroy(this.gameObject);
        }
    }
}
