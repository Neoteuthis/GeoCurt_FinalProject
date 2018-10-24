using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {
    //vars
    public int lives; //extras chances
    public int HP; //character health
    public int currentitem; //enum? each weapon type can have a number associated with it.
    public float movespeed = 1000f; //speed multiplier applied to unit vector for motion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //movement code
            float LR = Input.GetAxisRaw("Horizontal");
            float UD = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(LR* movespeed, 0) ;
        }
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, UD* movespeed) ;
        }
        if(Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W))
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
