using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string itemName;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "player"){
            GameObject play = other.gameObject;
            Debug.Log(play.name);
            Collector col = play.GetComponent<Collector>();
            if(col != null){
                col.addItem(itemName);
                Destroy(this.gameObject);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
