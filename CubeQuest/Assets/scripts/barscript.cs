using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barscript : MonoBehaviour {
    GameObject player;
    public bool isHP;
    public bool ismana;
    float hp;
    float maxhp;
    float hpfrag;
    float mp;
    float maxmp;
    float mpfrag;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindWithTag("Player");
        hp = playerscript.HP;//player.GetComponent<playerscript>().HP;
        maxhp = player.GetComponent<playerscript>().MAXHP;
        hpfrag = hp/maxhp;
        mp = playerscript.mana;//player.GetComponent<playerscript>().HP;
        maxmp = player.GetComponent<playerscript>().MAXmana;
        mpfrag = mp / maxmp;
        if (isHP == true)
        {
            
            transform.localScale = new Vector3(0.1f, hpfrag, 1);
        } else
        {
            transform.localScale = new Vector3(0.1f, mpfrag, 1);
            GetComponent<SpriteRenderer>().color = new Color(00, 0, 255, 100);
        }
    }
}
