using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGamePanel : MonoBehaviour
{
    [SerializeField]
    Text ScoreText;
    static Text ScoreText2;
    public static int score;

    public void ReturnToMainMenu()
     {
          SceneManager.LoadScene("MainMenu");
     }
    
    private void Start()
    {
        score = 0;
        ScoreText2 = ScoreText;
    }
    public static void updateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        ScoreText2.text = "Score: " + score.ToString();
    }
}
