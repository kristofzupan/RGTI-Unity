using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.countDown)
        {
            startTime = Time.time;
            return;
        }
        TimeSpan t = TimeSpan.FromSeconds(Time.time - startTime);

        string minutes = "";
        string seconds = "";
        string milisec = "";
        if (t.Minutes < 10)
        {
            minutes = "0" + t.Minutes.ToString();
        } else
        {
            minutes = t.Minutes.ToString();
        }

        if (t.Seconds < 10)
        {
            seconds = "0" + t.Seconds.ToString();
        } else
        {
            seconds = t.Seconds.ToString();
        }

        if (t.Milliseconds < 100)
        {
            milisec = "0" + t.Milliseconds.ToString();
        } else
        {
            milisec = t.Milliseconds.ToString();
        }

        timerText.text = minutes+ ":" + seconds + ":" + milisec;
    }
}
