using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeControl : MonoBehaviour
{
    public void changeGlobalVolume(float volume)
    {
        audioManager AM = FindObjectOfType<audioManager>();
        AM.setGlobalVolume(volume);
    }
}
