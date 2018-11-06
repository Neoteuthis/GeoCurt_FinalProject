using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textscript : MonoBehaviour {
  //  GameObject player = GameObject.FindWithTag("player");
    public Text thistext;
    public Text thattext;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        thistext.text = playerscript.score.ToString();
        thattext.text = playerscript.highscore.ToString();
    }
}
