using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barscript : MonoBehaviour {
    GameObject player;
    public bool isHP;
    public bool ismana;
    int hp;
    int maxhp;
    int hpfrag;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindWithTag("Player");
        hp = player.GetComponent<playerscript>().HP;
        maxhp = player.GetComponent<playerscript>().MAXHP;
        hpfrag = hp/maxhp;
        if (isHP == true)
        {
            
            transform.localScale = new Vector3(0.1f, hpfrag, 1);
        }
    }
}
