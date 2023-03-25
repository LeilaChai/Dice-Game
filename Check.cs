using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum BattleState {Player1Turn, Player2Trun}

public class Check : MonoBehaviour
{
    public BattleState state;

    Vector3 diceVelocity;
    Vector3 dice2Velocity;
    public int Dice1;
    public int Dice2;
    private int PlayerScore;
    public int TotalScore;
    private int PlayerScore2;
    public int TotalScore2;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI ScoreText2;
    public TextMeshProUGUI YouWin;
    public TextMeshProUGUI YouLose;

    void Start()
    {
        TotalScore = 0;
        TotalScore2 = 0;
        YouWin.text = "";
        YouLose.text = "";
        Dice1 = 0;
        Dice2 = 0;
    }

    void SetScoreText ()
    {
        
        if (Dice1 == 1 && Dice2 ==1 ){
            YouLose.text = "You Lose!";
        }

    
        if (TotalScore >= 50) 
        {
            YouWin.text = "You Win!";
        } 

    

        else 
        {
            ScoreText.text = TotalScore.ToString ();
            
        }
    }

    void SetScoreText2 ()
    {
        if (TotalScore2 >= 50) 
        {
            YouWin.text = "You Win!";
        } 

        else
        {
            ScoreText2.text = TotalScore2.ToString ();
        }
    }




    void FixedUpdate()
    {
        diceVelocity = Dice.diceVelocity;

    }


    
    public void UpdateScore ()
    {
        PlayerScore = Dice1 + Dice2;
        TotalScore += PlayerScore;
        SetScoreText ();
    }

    public void UpdateScore2 ()
    {
        PlayerScore2 = Dice1 + Dice2;
        TotalScore2 += PlayerScore2;
        SetScoreText2 ();
    }

    

    void OnTriggerStay(Collider col)
    {


        if(diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f){
            switch (col.gameObject.name){
            case "side1":
                Dice1 = 6;
                break;
            case "side2" :
                Dice1 = 5;
                break;
            case "side3":
                Dice1 = 4;
                break;
            case "side4":
                Dice1 = 3;
                break;
            case "side5":
                Dice1 = 2;
                break;
            case "side6":
                Dice1 = 1;
                break;
            

            }

            

        }

        if(dice2Velocity.x == 0f && dice2Velocity.y == 0f && dice2Velocity.z == 0f){
            switch (col.gameObject.name){
            case "side1.1":
                Dice2 = 6;
                break;
            case "side2.1" :
                Dice2 = 5;
                break;
            case "side3.1":
                Dice2 = 4;
                break;
            case "side4.1":
                Dice2 = 3;
                break;
            case "side5.1":
                Dice2 = 2;
                break;
            case "side6.1":
                Dice2 = 1;
                break;
            

            }

            

        }

        
        
    }
}
