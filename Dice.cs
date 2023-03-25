using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    
   static Rigidbody rb;
   public static Vector3 diceVelocity;
   Check check;
   public BattleState state;

    void Start()
    {
        check = GameObject.FindGameObjectWithTag("check").GetComponent<Check>();
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Roll(rb);
            if (check.state == BattleState.Player1Turn)
            {
                StartCoroutine(StartR());
            }
                
            if (check.state == BattleState.Player2Trun)
            {
                StartCoroutine(StartR2());
            }
        }   
    }

    IEnumerator StartR(){
        yield return new WaitForSeconds(6f);
        // print("bshdgcjsh");
        check.UpdateScore();
        check.state = BattleState.Player2Trun;
        StopCoroutine(StartR());
    }

    IEnumerator StartR2(){
        yield return new WaitForSeconds(6f);
        // print("bshdgcjsh");
        check.UpdateScore2();
        check.state = BattleState.Player1Turn;
        StopCoroutine(StartR2());
    }

    void Roll(Rigidbody rb){
            // DiceNumberTextScript.diceNumber = 0;
            float dirX = Random.Range(0,500);
            float dirY = Random.Range(0,500);
            float dirZ = Random.Range(0,500);
            transform.position = new Vector3 (45,2,23);
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 1000);
            rb.AddTorque(dirX, dirY, dirZ);
             if (check.state == BattleState.Player1Turn)
                {
                    StopCoroutine(StartR());
                }
                
                if (check.state == BattleState.Player2Trun)
                {
                    StopCoroutine(StartR2());
                }
    }
}
