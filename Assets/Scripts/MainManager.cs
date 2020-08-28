﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] hearts;
    [SerializeField]
    private int life = 0;
    static int s_Life;
    static GameObject[] s_hearts;
    private void Start()
    {
        s_hearts = hearts;
        s_Life = life;
    }
    public static void LoseLife(int Amount)
    {
        s_Life -= Amount;
        s_hearts[s_Life].GetComponent<MeshRenderer>().enabled = false;
        InGamePanel.updateStreak(0);
        if (s_Life <= 0)
        {
             LoseGame();
        }
    }
    static void LoseGame()
    {
         ScoreScript.AddScore(InGamePanel.score);
         SceneManager.LoadScene("MainMenu");
    }
}

