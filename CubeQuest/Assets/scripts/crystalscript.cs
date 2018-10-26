using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalscript : MonoBehaviour {
     float HP = 5;
    float MAXHP = 255;
    float regenrate = 1;
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
        //GetComponent<SpriteRenderer>().color = new Color(255-HP, 0, HP, 100);
        if(HP < (MAXHP * 0.5))
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 100);
        } else if(HP < MAXHP) 
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 255, 100);
        } else
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 255, 100);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Sword"))
        {
            HP++;
        }
    }
}
