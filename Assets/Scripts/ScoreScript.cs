using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
     static GameObject ScoreObject = GameObject.Find("Score");
     public static int score = 0;

     public static void updateScore(int scoreToAdd)
     {
          score += scoreToAdd;
          ScoreObject.GetComponent<Text>().text = "Score: " + score.ToString();
     }
}

