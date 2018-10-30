using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimescript : MonoBehaviour
{
    public int maxspawns = 1;
    public int spawntime = 1200;
    public int maxspawntime = 1200;
   public int spawnvariance = 200;
   public int HP = 5;
   public int MAXHP = 5;
    Vector3 currentpos;
    // Use this for initialization
    void Start()
    {
        spawntime += Random.Range(-spawnvariance,spawnvariance);
    }

    // Update is called once per frame
    void Update()
    {
        
        currentpos = gameObject.transform.position;
        spawntime--;
        if(spawntime < 0)
        {
            spawnNewSlime();
            spawntime = maxspawntime;
        }
        if(HP<= 0)
        {
            gameObject.SetActive(false);
        }
    }
    //multiply
    public void spawnNewSlime()
    {
        int spawnNum = maxspawns;
        while (spawnNum > 0)
        {
            GameObject slime = objectpooler.SharedInstance.GetPooledObject("GreenSlime");
            if (slime != null)
            {
                slime.transform.position =currentpos;
                slime.SetActive(true);
            }
            spawnNum--;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Sword")|| collision.gameObject.tag == ("Boomerang"))
        {
            HP--;
        }
    }
}
