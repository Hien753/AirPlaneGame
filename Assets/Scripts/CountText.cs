using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText: MonoBehaviour
{
    public static int score;
    public Text scoreText;

    private void Start()
    {
        score = 0;
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
