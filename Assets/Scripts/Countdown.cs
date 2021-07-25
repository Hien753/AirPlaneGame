using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{

    public float countdown = 300.0f;

    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        countdown -= Time.deltaTime;

        timeText.text = countdown.ToString("f1") + "•b";

        if (countdown <= 0)
        {
            SceneManager.LoadScene("result");
        }

    }

    
}
