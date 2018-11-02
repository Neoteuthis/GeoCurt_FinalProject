using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalscript : MonoBehaviour {
    public float HP = 5;
   public float MAXHP = 255;
    float regenrate = 0.5f;
    // Use this for initialization
    void Start () {

        }

    // Update is called once per frame
    void Update()
    {
        if (startscript.gamestarted)
        {
            //HPfixing
            if (HP < (MAXHP - 10))
            {
                //regenerate hp
                HP += regenrate;
            }
            if (HP < 0)
            {
                HP = 0;
            }
            ///update into lerp function!!

            if (HP < (MAXHP * 0.5))
            {
                GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 100);
            }
            else if (HP < MAXHP)
            {
                GetComponent<SpriteRenderer>().color = new Color(255, 0, 255, 100);
            }
            else
            {
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 255, 100);
                HP = MAXHP;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("GreenSlime"))
        {
            HP-=20;
        }
        if (collision.gameObject.tag == ("Rod"))
        {
            HP += 20;
        }
    }
}
