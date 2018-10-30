using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomerangscript : MonoBehaviour
{
    float xvel = 0;
    float yvel = 0;
    float movespeed = 5;
    float tossdistance = 50;
    float maxtossdistance = 100;
    float lifespan = 300;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tossdistance--;
        lifespan--;
        //update from random to getting player direction
        int ipswitch = Random.Range(0, 3);
        switch (ipswitch)
        {
            case 0:
                xvel = 0;
                yvel = movespeed;
                break;
            case 1:
                xvel = 0;
                yvel = -movespeed;
                break;
            case 2:
                xvel = movespeed;
                yvel = 0;
                break;
            case 3:
                xvel = -movespeed;
                yvel = 0;
                break;
            default:
                xvel = 0;
                yvel = movespeed;
                break;
               
        }
        if(tossdistance<= 0)
        {
            xvel *= -1;
            yvel *= -1;
            tossdistance = maxtossdistance;
        }
     GetComponent<Rigidbody2D>().velocity = new Vector2(xvel, yvel);
        if (lifespan<= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
