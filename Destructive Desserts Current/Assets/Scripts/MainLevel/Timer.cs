using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{

    public float timeLeft;
    public float timePassed;
    public bool timerRunning;

    public TextMeshPro timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerRunning = true;
        timerText = gameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                timePassed += Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                timeLeft = 0;
                timerRunning = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
