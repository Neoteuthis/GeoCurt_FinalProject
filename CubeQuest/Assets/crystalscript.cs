using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalscript : MonoBehaviour {
    public float HP = 200;
    public float MAXHP = 200;
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
	}
}
