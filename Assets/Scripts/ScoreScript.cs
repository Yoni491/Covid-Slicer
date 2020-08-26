using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
     [SerializeField] Text Scores;
     [SerializeField] Text Dates;
     static Text s_Score;
     static Text s_Date;
     static int MaxScores = 5;
     static int ScoresAmount = 0;
     static PlayerScore[] currentScores = new PlayerScore[MaxScores];

    private void Start()
    {
        s_Score = Scores;
        s_Date = Dates;
    }

     public static void AddScore(int i_Score) // ADD NEW SCORE TO LEADERBOARDS
     {
        PlayerScore NewScore = new PlayerScore(i_Score);
        for (int i = 0; i < 5; i++)
        {
            if (i >= ScoresAmount)
            {
                currentScores[i] = NewScore;
                ScoresAmount++;
                break;
            }

            if (i_Score > currentScores[i].m_Score)
            {
                PlayerScore temp = currentScores[i];
                currentScores[i] = NewScore;
                NewScore = temp;
            }
        }
        //UpdateLeaderboard();
     }

     static void UpdateLeaderboard()
     {
          string LeaderboardScore = "";
          string LeaderboardDate = "";

          for(int i = 0; i < currentScores.Length; i++)
          {
               LeaderboardScore += (i + 1) + ". " + currentScores[i].m_Score + "\n";
               LeaderboardDate += currentScores[i] + "\n";
          }

          s_Score.text = LeaderboardScore;
          s_Date.text = LeaderboardDate;
     }
}
public class PlayerScore
{
     public int m_Score;
     private string m_ScoreDate;

     public PlayerScore(int Score)
     {
          m_Score = Score;
          m_ScoreDate = System.DateTime.Today.ToShortDateString();
     }
}