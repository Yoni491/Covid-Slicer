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
    public static int score;
    public static int streak;
    public static int combo;
    static float timer;
    static float lastFruitSliceTime;
    static int comboStreak;
    static bool b_resetCombo;

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

     private void Update()
     {
          timer += Time.deltaTime;
     }

     public static void updateScore(int scoreToAdd)
     {
          score += scoreToAdd;
          s_ScoreText.text = "Score: " + score.ToString();
          updateStreak(1);
     }

     public static void updateStreak(int streakToAdd)
     {
          if(streakToAdd == 0)
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
          if(comboToAdd == 0)
          {
               resetCombo();
          }

          else
          {
               if(timer - lastFruitSliceTime < 0.35f || lastFruitSliceTime == 0)
               {
                    lastFruitSliceTime = timer;
                    comboStreak++;
               }

               else
               {
                    if(comboStreak <= 1)
                    {
                         resetCombo();
                    }

                    lastFruitSliceTime = timer;
                    comboStreak = 1;

               }

               combo += comboToAdd;
               if(combo > 1)
               {
                    s_ComboPanel.SetActive(true);
               }

               s_ComboText.text = combo.ToString();
          }
     }

     public static void resetCombo()
    {
        updateScore(combo*((combo/10) >2? combo / 10 : 2));
        lastFruitSliceTime = 0;
        timer = 0;
        combo = 0;
        s_ComboPanel.SetActive(false);
        b_resetCombo = false;
    }
}