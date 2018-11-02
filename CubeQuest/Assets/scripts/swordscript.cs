using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordscript : MonoBehaviour
{
    public bool isSword;
    public bool isWand;
    public float swingdistance = 450;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Rigidbody2D>().rotation -= 10;
        //    while (swingdistance >= 0)
        //{
        //    GetComponent<Rigidbody2D>().rotation += 5;
        //    swingdistance--;
        //    if(swingdistance == 0)
        //    {
        //        GetComponent<Rigidbody2D>().rotation = 0;
               
        //       // return;
        //    } 
        //}swingdistance = 450;// swing();
        }
    }
   // void swing()
   // {
   //     
  //  }
}
