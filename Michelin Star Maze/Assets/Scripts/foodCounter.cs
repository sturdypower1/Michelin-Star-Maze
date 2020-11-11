using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class foodCounter : MonoBehaviour
{
    public GameObject appleCount;
    public GameObject chickenCount;
    public GameObject broccoliCount;
    public GameObject oilCount;
    public GameObject onionCount;

    public foodChecker FCH;

    private void Start()
    {
        changeApple(0);
        changeChicken(0);
        changeBroccoli(0);
        changeOil(0);
        changeOnion(0);
    }

    public void changeApple(int num){
        Text appleTxt = appleCount.GetComponent<Text>();
        appleTxt.text = "Apples" + " " + num.ToString() + "/" + FCH.requiredApples;
    }
    public void changeChicken(int num){
        Text chickenTxt = chickenCount.GetComponent<Text>();
        chickenTxt.text = "Chicken" + " " + num.ToString() + "/" + FCH.requiredChicken.ToString();
    }
    public void changeBroccoli(int num)
    {
        Text broccoliTxt = broccoliCount.GetComponent<Text>();
        broccoliTxt.text = "Broccoli" + " " + num.ToString() + "/" + FCH.requiredBroccoli.ToString();
    }
    public void changeOil(int num)
    {
        Text oilTxt = oilCount.GetComponent<Text>();
        oilTxt.text = "Oil" + " " + num.ToString() + "/" + FCH.requiredOil.ToString();
    }
    public void changeOnion(int num)
    {
        Text onionTxt = onionCount.GetComponent<Text>();
        onionTxt.text = "Onion" + " " + num.ToString() + "/" + FCH.requiredOnion.ToString();
    }
}
