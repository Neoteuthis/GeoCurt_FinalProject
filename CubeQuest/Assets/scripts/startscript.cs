using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscript : MonoBehaviour {
    public static bool gamestarted = false;
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		 if (Input.anyKey)
        {
            gamestarted = true;
            Destroy(gameObject);
        }
	}
}
