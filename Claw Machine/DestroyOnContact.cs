using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnContact : MonoBehaviour {
   
    private float Result;
    public Text TimerText;
    public Text EndText;
    //public Text MenuText;
    public Text OnGoingScore;
    private int PrizeCount = LevelSelection.PrizeNum;
    public float StartTime;
    private float TimeLimit = LevelSelection.UserTimeLimit;
    public Button Return;
    private bool finished = false;

    void Start()
    {
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
            string EndScore = ((int)Result).ToString();
            if (finished == true)
            {

                TimerText.color = Color.red;
            if (PrizeCount != 0)
            {
                TimerText.text = 0 + ":" + 0 + 0 + "." + 0 + 0;
            }
                EndText.text = "SCORE:" + EndScore;
                //MenuText.text = "MAIN MENU";
                Return.gameObject.SetActive(true);
                return;
            }

            float time_passed = Time.time - StartTime;
            float t = TimeLimit - time_passed;
            if (t < 0 || PrizeCount == 0)
            {
                finished = true;
            }
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            TimerText.text = minutes + ":" + seconds;
            OnGoingScore.text = EndScore;
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "prize")
        {
            Debug.Log("collision detected!");
            Destroy(other.gameObject);
            Result++;
            PrizeCount--;
        }
    }
}
