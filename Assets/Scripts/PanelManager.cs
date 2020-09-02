using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
     [SerializeField] GameObject HowToPopUp = null;
     [SerializeField] GameObject ScoreboardPopUp = null;
     [SerializeField] GameObject LostPopUp = null;
     [SerializeField] Text LostPopUpText = null;
     public static bool playerLost;

     public void startGame()
     {
          SceneManager.LoadScene("Fruit Ninja");
     }

     public void showScores()
     {
          ScoreScript.UpdateLeaderboard();
          ScoreboardPopUp.SetActive(true);
     }

     public void HowToPlay()
     {
          HowToPopUp.SetActive(true);
     }

     public void CloseHowToPlay()
     {
          HowToPopUp.SetActive(false);
     }

     public void CloseScoreboard()
     {
          ScoreboardPopUp.SetActive(false);
          SceneManager.LoadScene("MainMenu");
     }

     public void QuitGame()
     {
          Application.Quit();
     }

     private void OnEnable()
     {
          if(playerLost)
          {
               LostPopUpText.text = "Your score is: " + InGamePanel.score.ToString();
               LostPopUp.SetActive(true);
               playerLost = false;
          }
     }
}
