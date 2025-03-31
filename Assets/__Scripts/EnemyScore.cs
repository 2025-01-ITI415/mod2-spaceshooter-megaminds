using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScore : MonoBehaviour
{
    [SerializeField]
    private int          _killScore;

    private ScoreTracker scoreController;

    private void Awake()
    {
        scoreController = FindObjectOfType<ScoreTracker>();
    }

    public void AssignScore()
    {
        scoreController.AddScore(_killScore);
    }
}