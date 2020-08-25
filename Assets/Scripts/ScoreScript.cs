using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
     [SerializeField] static Text Scores;
     [SerializeField] Transform Dates;

     static void AddScore(int score)
     {
          Scores.text += "\n" + "2." + score.ToString();
     }
}
