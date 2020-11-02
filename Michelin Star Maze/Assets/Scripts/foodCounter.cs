using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class foodCounter : MonoBehaviour
{
    public GameObject appleCount;
    public GameObject bananaCount;
    public void changeApple(int num){
        Text appleTxt = appleCount.GetComponent<Text>();
        appleTxt.text = "Apples" + " " + num.ToString();
    }
    public void changeBanana(int num){
        Text bananaTxt = bananaCount.GetComponent<Text>();
        bananaTxt.text = "Banana" + " " + num.ToString();
    }

}
