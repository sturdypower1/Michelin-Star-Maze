using System;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static audioManager instance;

    private float globalVolume = 1.0f;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);


        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume * globalVolume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    private void Start()
    {
        if (!isPlaying("MenuMusic"))
        {
            play("MenuMusic");
        }
    }

    public bool isPlaying(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("name not found");
            return false;
        }
        return s.source.isPlaying;
    }

    public void stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("name not found");
            return;
        }
        s.source.Stop();
    }

    public void play(string name){
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("name not found");
            return;
        }
        s.source.Play();
    }

    public void mute(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("name not found");
            return;
        }
        s.source.mute = true;
    }
    public void unmute(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("name not found");
            return;
        }
        s.source.mute = false;
    }

    public void setGlobalVolume(float volume)
    {
        globalVolume = volume;
        foreach (Sound s in sounds)
        {
            s.source.volume = s.volume * globalVolume;
        }
    }
}
