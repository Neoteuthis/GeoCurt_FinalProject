using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordscript : MonoBehaviour {
    public int spin;
    public bool isSword;
    public bool isWand;
    public bool isBoomerang;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().rotation += spin;
    }
    void toss()
    {

    }
}
