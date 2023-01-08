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

        timerText.text = t.Minutes.ToString() + ":" + t.Seconds.ToString() + ":" + t.Milliseconds.ToString();
    }
}
