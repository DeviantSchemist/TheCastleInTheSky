﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jellyfish : MonoBehaviour {

    private const float JELLY_WEIGHT = 30f;
    public Transform target;
    public float speed;

	// Use this for initialization
	void Start () {
        target = GameObject.Find("Ship").GetComponent<Transform>();
        speed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;  // movement speed
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);  // gradual movement
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
