using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Functionality : MonoBehaviour
{
   public void PlayGame () {
        SceneManager.LoadScene("Tutorial");
    }
    public void BacktoMain ()
    {
        SceneManager.LoadScene("Menu 2");
    }
    public void OptionsMenu ()
    {
        SceneManager.LoadScene("Options Menu");
    }
}
