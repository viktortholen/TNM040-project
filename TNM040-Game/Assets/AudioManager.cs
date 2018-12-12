using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour {

    public Sound[] sounds;

    public static AudioManager instance;
	// Use this for initialization
	void Awake () {

        //if(instance == null)
        //{
        //    instance = this;
        //}
        //else
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //DontDestroyOnLoad(gameObject);

		foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            FindObjectOfType<AudioManager>().Play("soundtrack");
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            FindObjectOfType<AudioManager>().Stop("soundtrack");
            FindObjectOfType<AudioManager>().Play("soundtrack_buildupochdrop");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            FindObjectOfType<AudioManager>().Stop("soundtrack_buildupochdrop");
            FindObjectOfType<AudioManager>().Play("psy");
        }
    }

    void Start()
    {

    }

    public void Play(string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " was not found!");
                return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " was not found!");
            return;
        }
        s.source.Stop();
    }
}
