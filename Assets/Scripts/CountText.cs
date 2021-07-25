using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText: MonoBehaviour
{
    int score;
    public Text scoreText;
    void Start()
    {
        score = -1200;
    }

    public void AddScore()
    {
        score += 100;
    }

    public void AddScore2()
    {
        score += 500;
    }

    private void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }
}
