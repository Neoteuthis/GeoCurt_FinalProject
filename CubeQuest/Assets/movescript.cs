﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour {
    public bool isroaming;
    public bool isseekingcrystal;
    public bool isseekingplayer;
    public bool isrunning;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		var X = gameObject.transform.position;
        gameObject.transform.Translate(Random.Range(-0.1f,0.1f), Random.Range(-0.1f, 0.1f),0);

    }
}
