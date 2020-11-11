using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeLeft;
    private bool isTimerRunning;

    public Text timerTxt;
    public foodChecker FC;

    private void Start() {
        timerTxt = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        if(isTimerRunning && timeLeft > 0){
            timeLeft -= Time.deltaTime;
            timerTxt.text = "Time left: " + timeLeft.ToString();
        }
        else if(isTimerRunning){
            isTimerRunning = false;
            FC.timerFinished();
        }
    }
    
    public void startTimer(float time){
        isTimerRunning = true;
        timeLeft = time;
    }
    
    public void stopTimer(){
        audioManager s = FindObjectOfType<audioManager>();
        s.play("time");
        isTimerRunning = false;
        timeLeft = 0.0f;
    }
    
}
