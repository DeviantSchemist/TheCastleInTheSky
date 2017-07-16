using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jellyfish : MonoBehaviour {

    private const float JELLY_WEIGHT = 30f;
    public Transform target;
    public float speed;

	// Use this for initialization
	void Start () {
        target = GameObject.Find("Ship").GetComponent<Transform>();
        speed = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;  // movement speed
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);  // gradual movement
	}

    void onCollisionEnter(Collision2D collision)
    {
        if (collision.gameObject.name == "Civilian" || collision.gameObject.name == "Soldier" || collision.gameObject.name == "Engineer"
            || collision.gameObject.name == "Ship")
        {
            Destroy(this.gameObject);
        }
    }
}
