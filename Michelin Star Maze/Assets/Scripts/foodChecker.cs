using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodChecker : MonoBehaviour
{
    
    public messageSystem mesSys;
    public Timer tim;
    public GameObject RB;

    public int requiredApples;
    public int requiredBananas;
    public float timeLimit;

    private bool gameRunning = true;

    private void Start() {
        gameRunning = true;
        tim.startTimer(timeLimit);
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("object entered");
        if (gameRunning){
            if (other.tag == "player"){
                GameObject play = other.gameObject;
                Collector col = play.GetComponent<Collector>();
                if ((col.getApples() >= requiredApples) && (col.getBananas() >= requiredBananas)){
                    mesSys.displayMessage("You Collected all the Items!");
                    tim.stopTimer();
                }
            }
        }
    }

    public void timerFinished(){
        Time.timeScale = 0.0f;
        RB.SetActive(true);
        gameRunning = false;
    }
}
