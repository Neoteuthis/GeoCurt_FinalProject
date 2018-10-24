using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squarescript : MonoBehaviour {
    public bool isred = true;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.E))
        {
            isred = true;
        }
            if (isred == true)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 255, 100);
        } else
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 100);
        }
	}
   
}
