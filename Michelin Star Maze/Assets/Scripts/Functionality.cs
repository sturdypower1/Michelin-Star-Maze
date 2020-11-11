using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Functionality : MonoBehaviour
{
   
   public void PlayGame () {
        SceneManager.LoadScene("Tutorial");
        audioManager s = FindObjectOfType<audioManager>();
        s.play("backgroundMusic");
        s.mute("MenuMusic");    
    }
    public void BacktoMain ()
    {
        SceneManager.LoadScene("Menu 2");
        audioManager s = FindObjectOfType<audioManager>();
        s.play("backgroundMusic");
        s.stop("backgroundMusic");
        s.unmute("MenuMusic");
        Time.timeScale = 1.0f;
    }
    public void OptionsMenu ()
    {

        SceneManager.LoadScene("Options Menu");
    }
}
