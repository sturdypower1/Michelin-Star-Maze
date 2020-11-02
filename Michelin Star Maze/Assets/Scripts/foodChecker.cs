using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodChecker : MonoBehaviour
{
    
    public messageSystem mesSys;
    public int requiredApples;
    public int requiredBananas;
    private void OnTriggerEnter(Collider other) {
        Debug.Log("object entered");
        if (other.tag == "player"){
            GameObject play = other.gameObject;
            Collector col = play.GetComponent<Collector>();
            if ((col.getApples() >= requiredApples) && (col.getBananas() >= requiredBananas)){
                mesSys.displayMessage("You Collected all the Items!");
            }
        }
    }
}
