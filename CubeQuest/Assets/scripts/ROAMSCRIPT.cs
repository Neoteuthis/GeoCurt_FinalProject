using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROAMSCRIPT : MonoBehaviour {
    int movespeed = 4;
    public int maxspawns = 1;
    public int spawntime = 1200;
    public int maxspawntime = 1200;
    public int spawnvariance = 200;
    public int HP = 5;
    public int spawntype = 0;
    public int MAXHP = 5;
    Vector3 currentpos;
    GameObject enemy;
    // Use this for initialization
    void Start()
    {
        spawntime += Random.Range(-spawnvariance, spawnvariance);
    }

    // Update is called once per frame
    void Update()
    {
        if (startscript.gamestarted && startscript.StateMachine == startscript.gamestate.playing)
        {
            currentpos = gameObject.transform.position;
            spawntime--;
            if (spawntime < 0)
            {
                spawnNewSlime();
                spawntime = maxspawntime;
            }
            if (HP <= 0)
            {
                gameObject.SetActive(false);
            }
        }
        GetComponent<Rigidbody2D>().position = new Vector2(Random.Range(-movespeed, movespeed), Random.Range(-movespeed, movespeed));
    }
    //multiply
    public void spawnNewSlime()
    {
        int spawnNum = maxspawns;
        while (spawnNum > 0)
        {
            spawntype = Random.Range(0, 2);
            switch (spawntype)
            {
                case 0:
                    enemy = objectpooler.SharedInstance.GetPooledObject("GreenSlime");
                    break;
                case 1:
                    enemy = objectpooler.SharedInstance.GetPooledObject("Roamer");
                    break;
                default:
                    enemy = objectpooler.SharedInstance.GetPooledObject("SlimeKing");
                    break;
            }
           

            if (enemy != null)
            {
                enemy.transform.position = currentpos;
                enemy.SetActive(true);
            }
            spawnNum--;
        }
    }
}
