using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGamePanel : MonoBehaviour
{
    [SerializeField] Text ScoreText = null;
    [SerializeField] Text StreakText = null;
    static Text s_ScoreText;
    static Text s_StreakText;
    public static int score =0;
    public static int streak = 0;

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Start()
    {
        s_ScoreText = ScoreText;
        s_StreakText = StreakText;
    }
    public static void updateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        s_ScoreText.text = "Score: " + score.ToString();
        updateStreak(1);
    }
    public static void updateStreak(int streakToAdd)
    {
        if(streakToAdd==0)
        {
            streak = 0;
        }
        else
        {
            streak += streakToAdd;
        }
        s_StreakText.text = "Streak: " + streak.ToString();
    }
}