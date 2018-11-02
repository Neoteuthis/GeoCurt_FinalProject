using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {
    //vars
    public int lives; //extras chances
    public static float HP = 50; //character health
    public float MAXHP = 50;
    public int currentitem; //enum? each weapon type can have a number associated with it.
    public float movespeed = 1000f; //speed multiplier applied to unit vector for motion
    public Vector3 currentpos;
    public float rangtime;
    public float maxrangtime = 60;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rangtime--;
        if (startscript.gamestarted)
        {
            currentpos = gameObject.transform.position;
            //movement code
            float LR = Input.GetAxisRaw("Horizontal");
            float UD = Input.GetAxisRaw("Vertical");
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(LR * movespeed, 0);
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, UD * movespeed);
            }
            if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W))
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            if (Input.GetKey(KeyCode.E))
            {
                if (rangtime <= 0) { 
                     GameObject rang = objectpooler.SharedInstance.GetPooledObject("Boomerang");
                     if (rang != null)
                     {
                         rang.transform.position = currentpos;
                         rang.SetActive(true);
                        rangtime = maxrangtime;
                     }
                }
            }
        }
    }
}
