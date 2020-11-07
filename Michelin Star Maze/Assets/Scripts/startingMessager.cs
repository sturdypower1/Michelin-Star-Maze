using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startingMessager : MonoBehaviour
{
    public GameObject[] messages;
    public GameObject button;
    private int i = 0;
    
    void Start()
    {
        i = 0;
        Time.timeScale = 0.0f;
        startMessenger();
    }
    //can't be used to display the first message
    public void displayNext(){
        i++;
        messages[i - 1].SetActive(false);
        if(i < messages.Length){
            messages[i].SetActive(true);
        }
        else{
            Time.timeScale = 1.0f;
            button.SetActive(false);
        }
    }
    public void startMessenger(){
        button.SetActive(true);
        if( !(messages.Length == 0)){
            messages[0].SetActive(true);
        }
        else{
            Time.timeScale = 1.0f;
            button.SetActive(false);
        }
    }

    public void skip(){
        foreach( GameObject mes in messages){
            mes.SetActive(false);
        }
        button.SetActive(false);
    }
}
