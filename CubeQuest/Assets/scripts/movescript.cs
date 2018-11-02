using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
{
    public bool isroaming;
    public bool iswalking;
    public bool isseekingcrystal;
    public bool isseekingplayer;
    public bool isrunning;
    public float movespeed = 2;
    public int changedir = 50;
    public float xvel = 0;
    public float yvel = 0;
    GameObject player;
    public Vector3 currentpos;
    //GameObject player;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (startscript.gamestarted && startscript.StateMachine == startscript.gamestate.playing)
        {
            var X = gameObject.transform.position;
            //gameObject.transform.Translate(Random.Range(-0.1f,0.1f), Random.Range(-0.1f, 0.1f),0);
            if (isroaming)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-movespeed, movespeed), Random.Range(-movespeed, movespeed));
            }
            if (iswalking)
            {
                changedir--;
                if (changedir <= 0)
                {
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
                    changedir = 50;
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(xvel, yvel);

            }
            if (isseekingplayer)
            {
                player = GameObject.FindWithTag("Player");
                currentpos = gameObject.transform.position;
                if (player.GetComponent<playerscript>().currentpos.x >= this.currentpos.x)
                {
                    xvel = movespeed;
                }
                else
                {
                    xvel = -movespeed;
                }
                if (player.GetComponent<playerscript>().currentpos.y >= this.currentpos.y)
                {
                    yvel = movespeed;
                }
                else
                {
                    yvel = -movespeed;
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(xvel, yvel);
            }
        }
    }
}