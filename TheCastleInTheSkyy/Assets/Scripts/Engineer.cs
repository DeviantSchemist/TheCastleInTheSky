using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer : Civilian {

    private int engAmount;
    private float dieTime;
    private float engTime;
    bool becomeEng;

	// Use this for initialization
	void Start () {
        engTime = 6f;
        becomeEng = false;
	}
	
	// Update is called once per frame
	void Update () {
        engTime -= Time.deltaTime;
        if (engTime < 0)
        {
            becomeEng = true;
        }
	}

    int getEngAmount()
    {
        return engAmount;
    }

    bool engCheck()
    {
        return becomeEng;
    }
}
