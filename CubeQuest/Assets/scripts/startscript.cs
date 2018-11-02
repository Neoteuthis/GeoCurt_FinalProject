using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscript : MonoBehaviour {
    public static bool gamestarted = false;
   public enum gamestate {mainmenu, paused, playing, dead};

    public static gamestate StateMachine;
	// Use this for initialization
	void Start () {
        StateMachine = gamestate.mainmenu;
    }
	
	// Update is called once per frame
	void Update () {
		 if (Input.anyKey)
        {
            gamestarted = true;
            StateMachine = gamestate.playing;
            Destroy(gameObject);
        }
	}
}
