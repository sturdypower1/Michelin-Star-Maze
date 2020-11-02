using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
   private int apples = 0;
   private int beef = 0;
   private int bananas = 0;

   public foodCounter FC;

   public void addItem(string itemName){
       if(itemName == "apple"){
           apples++;
           FC.changeApple(apples);
       }
       else if(itemName == "beef"){
            beef++;

       }
       else if(itemName == "banana"){
           bananas++;
           FC.changeBanana(bananas);
       }
   }
   public int getApples(){
       return apples;
   }
   public int getBananas(){
       return bananas;
   }

}
