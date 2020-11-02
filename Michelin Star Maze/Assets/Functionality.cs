using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Functionality : MonoBehaviour
{
   public void PlayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void BacktoMain ()
    {
        SceneManager.LoadScene(0);
    }
    public void OptionsMenu ()
    {
        SceneManager.LoadScene(2);
    }
}
