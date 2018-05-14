using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text TimerText;
    public float StartTime;
    public float TimeLimit;
    private bool finished = false;

	// Use this for initialization
	void Start () {
        StartTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        if (finished == true)
        {
            TimerText.text = 0 + ":" + 00 + "." + 0;
            return;
        }

        float time_passed = Time.time - StartTime;
        float t = TimeLimit - time_passed;
        if (t < 0)
        {
            finished = true;
        }
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        TimerText.text = minutes + ":" + seconds;

	}
}
