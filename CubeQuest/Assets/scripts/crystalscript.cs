using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalscript : MonoBehaviour {
    public float HP = 0;
    public float MAXHP = 255;
    public float regenrate = 1;
    // Use this for initialization
    void Start () {

        }
	
	// Update is called once per frame
	void Update () {
       
        if (HP < MAXHP) {
            //regenerate hp
            HP += regenrate;
        }
        ///update into lerp function!!
        GetComponent<SpriteRenderer>().color = new Color(255-HP, 0, HP, 100);
	}
}
