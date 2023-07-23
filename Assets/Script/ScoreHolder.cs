using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    private int _score;
    private int _highScore;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ScoreStart()
    {
        _score = 0;
    }

    public void IncreaseScore(int points)
    {
        _score += points;
    }

    public void HighScoreCheck()
    {
        if (_score > _highScore) _highScore = _score;
    }

}
