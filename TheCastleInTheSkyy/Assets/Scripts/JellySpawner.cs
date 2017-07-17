using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellySpawner : MonoBehaviour {

    float timer;
    public GameObject Jellyfish;

	// Use this for initialization
	void Start () {
        Jellyfish = Instantiate(Resources.Load("Jelly")) as GameObject;
        timer = 10f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Instantiate(Jellyfish, transform.position, Quaternion.identity);
            timer = 10f;
        }
	}
}
