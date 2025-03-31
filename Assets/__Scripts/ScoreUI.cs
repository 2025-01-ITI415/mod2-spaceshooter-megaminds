using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private Text      _ScoreController;

    private void Awake()
    {
        _ScoreController = GetComponent<Text>();
    }

    public void UpdateScore(ScoreTracker scoreController)
    {
        _ScoreController.text = $"Score: {scoreController}";
    }
}
