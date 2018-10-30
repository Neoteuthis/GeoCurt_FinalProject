using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squarescript : MonoBehaviour {
    public bool isred = true;
    public GameObject crystal;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (crystal.GetComponent <crystalscript>().HP <= 0)
        {
            isred = true;
        }
        if (crystal.GetComponent<crystalscript>().HP >= crystal.GetComponent<crystalscript>().MAXHP)
        {
            isred = false;
        }
        if (Input.GetKey(KeyCode.E))
        {
            isred = true;
        }
            if (isred == true)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 100);
        } else
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 255, 100);
        }
	}
   
}
