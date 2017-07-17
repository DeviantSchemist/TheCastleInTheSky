using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SpriteRenderer sprite = GameObject.Find("Layer4Background").GetComponent<SpriteRenderer>();
        Camera.main.orthographicSize = sprite.bounds.size.x * Screen.height / Screen.width * 1f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
