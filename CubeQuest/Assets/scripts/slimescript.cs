using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimescript : MonoBehaviour
{
    public int maxspawns = 1;
    public int spawntime = 1200;
    public int maxspawntime = 1200;
    Vector3 currentpos;
    // Use this for initialization
    void Start()
    {

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
    }
    //multiply
    public void spawnNewSlime()
    {
        int spawnNum = maxspawns;
        while (spawnNum >= 0)
        {
            GameObject slime = objectpooler.SharedInstance.GetPooledObject("Greenslime");
            if (slime != null)
            {
                slime.transform.position =currentpos;
                slime.SetActive(true);
            }
            spawnNum--;
        }
    }
}
