using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messageSystem : MonoBehaviour
{
    private float timeRemaining = 0;
    private float maxMassageTime = 0;
    private bool displayingMessage = false;
    Text txt;
    private void Start() {
        txt = gameObject.GetComponent<Text>();
    }
    public void displayMessage(string message, float messageTime = 5f){
        txt.text = message;
        timeRemaining = maxMassageTime = messageTime;
        displayingMessage = true;
    }
    private void Update() {
        if (timeRemaining > 0){
            txt.color = new Color(0f, 0f, 0f, timeRemaining/maxMassageTime);
            timeRemaining -= Time.deltaTime;
        }
        else if(displayingMessage){
            displayingMessage = false;
            txt.color = new Color(0f, 0f, 0f, 0);
        }
    }
}
