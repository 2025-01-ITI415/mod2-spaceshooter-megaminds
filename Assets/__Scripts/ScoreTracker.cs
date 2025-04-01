using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public int          score;
    public Text         scoreText;
    // public Text                     highscoreText;

    // int highscore                   = 0;
    void Start()
    {
        
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}