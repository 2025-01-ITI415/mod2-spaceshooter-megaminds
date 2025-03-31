using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public static ScoreTracker      instance;
    public Text                     scoreText;
    public Text                     highscoreText;

    public int score                { get; private set; }
    int highscore                   = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + "Score";
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }
}
