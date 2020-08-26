using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
     [SerializeField]
     private int life = 0;
     static int s_Life;

     private void Start()
     {
          s_Life = life;
     }
     public static void LoseLife(int Amount)
     {
          s_Life -= Amount;

          if (s_Life <= 0)
          {
               LoseGame();
          }
     }
     static void LoseGame()
     {
          ScoreScript.AddScore(InGamePanel.score);
          SceneManager.LoadScene("MainMenu");
     }
}

