using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGamePanel : MonoBehaviour
{
    [SerializeField] Text ScoreText = null;
    [SerializeField] Text StreakText = null;
    [SerializeField] Text ComboText = null;
    [SerializeField] GameObject ComboPanel = null;
    static Text s_ScoreText;
    static Text s_StreakText;
    static Text s_ComboText;
    static GameObject s_ComboPanel;
    public static int score =0;
    public static int streak = 0;
    public static int combo = 0;
    float timer = 0;
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Start()
    {
        s_ScoreText = ScoreText;
        s_StreakText = StreakText;
        s_ComboText = ComboText;
        s_ComboPanel = ComboPanel;
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
    public static void addCombo(int comboToAdd)
    {
        if (comboToAdd == 0)
        {
            combo = 0;
            s_ComboPanel.SetActive(false);
        }
        else
        {
            s_ComboPanel.SetActive(true);
            combo += comboToAdd;
            s_ComboText.text = comboToAdd.ToString();
        }
    }
}