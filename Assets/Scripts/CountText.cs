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
        score += 100;
    }

    public void AddScore2()
    {
        score += 500;
    }

    private void Update()
    {
        scoreText.text = "Œo‰ßŽžŠÔ" + Time.time  + "SCORE: " + score.ToString();
    }
}
