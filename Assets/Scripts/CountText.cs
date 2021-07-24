using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText: MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    private void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score++;
    }

    private void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }
}
