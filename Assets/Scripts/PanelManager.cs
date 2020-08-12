using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
     public void startGame()
     {
          SceneManager.LoadScene("Fruit Ninja");
     }

     public void showScores()
     {

     }

     public void HowToPlay()
     {

     }

     public void QuitGame()
     {
          Debug.Log("quit");
          Application.Quit();
     }
}
