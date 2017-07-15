using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void onCollisionEnter(Collision2D collision)
    {
        if (collision.gameObject.tag == "Civilian" || collision.gameObject.tag == "Soldier" || collision.gameObject.tag == "Engineer")
        {
            Destroy(collision.gameObject);
        }
    }
}
