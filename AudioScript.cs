using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {
    public AudioClip startClip;
    public AudioSource startSource;

    public AudioSource nowPlay;

    public AudioClip[] audioClips;
    public AudioSource[] audioSources;

    public bool start, played;
    public string status;
	// Use this for initialization
	void Start () {
        int size = audioClips.Length;
        for (int i=0;i<size;i++)
        {
            audioSources[i].clip = audioClips[i];
        }

        startSource.clip = startClip;
        startSource.Play();
        nowPlay = startSource;

        start = true;
        played = true;
        status = "";
	}
	
	// Update is called once per frame
	void Update () {
        
		if (start && !played && nowPlay)
        {
            nowPlay.Play();
            played = true;
        } else if (!start && played)
        {
            nowPlay.Pause();
            played = false;
        }
	}

    //change the 
    public void ChangeStatus(string newState)
    {
        status = newState;
    }

    public void SwitchAudio()
    {
        switch (status)
        {
            case "tut":
                break;
            case "start":
                nowPlay.Stop();
                nowPlay = audioSources[0];
                nowPlay.Play();
                break;
            case "normal":
                break;
            case "warning":
                nowPlay.Stop();
                nowPlay = audioSources[2];
                nowPlay.Play();
                break;
            case "back":
                nowPlay.Stop();
                nowPlay = audioSources[4];
                nowPlay.Play();
                break;
            case "winning":
                break;
            default:
                break;
        }
    }

    public void StartorPause(int i)
    {
        start = !start;
    }

    public void LoopStop(int i)
    {
        nowPlay.loop = false;
    }

    public void Mute(int i)
    {
        nowPlay.mute = !nowPlay.mute;
    }

    //private void Stop()
    //{
    //    audioSource1.Stop();
    //}
    //private void Play()
    //{
    //    audioSource1.Play();
    //}

    //private void Pause()
    //{
    //    audioSource1.Pause();
    //}

}
