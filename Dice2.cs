using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice2 : MonoBehaviour
{
   static Rigidbody rb;
   public static Vector3 dice2Velocity;
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        dice2Velocity = rb.velocity;

        if(Input.GetKeyDown(KeyCode.Space)){
            // DiceNumberTextScript.diceNumber = 0;
            float dirX = Random.Range(0,500);
            float dirY = Random.Range(0,500);
            float dirZ = Random.Range(0,500);
            transform.position = new Vector3 (42,2,16);
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 1000);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
