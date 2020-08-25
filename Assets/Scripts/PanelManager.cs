using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
     [SerializeField] GameObject HowToPopUp;
     [SerializeField] GameObject ScoreboardPopUp;

     public void startGame()
     {
          SceneManager.LoadScene("Fruit Ninja");
     }

     public void showScores()
     {
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
     }

     public void QuitGame()
     {
          Debug.Log("quit");
          Application.Quit();
     }
}
