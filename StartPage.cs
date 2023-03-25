using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPage : MonoBehaviour
{
   public void PlayButton()
   {
        SceneManager.LoadScene("DiceLevel");
   }
   
}
