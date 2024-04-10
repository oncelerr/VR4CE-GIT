using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AudioMngr : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource; 
    public AudioSource subtitleSource; 

    [Header("BG Music")]
    public AudioClip[] bgMusic;

    [Header("SFX")]
    public AudioClip whooseFire;
    public AudioClip lighterFX;
    public AudioClip openDoorFX;
    public AudioClip closeDoorFX;
    public AudioClip checkpointFX;
    public AudioClip collectedPointsFX;

    [Header("VRBot Voice Over")]
    public AudioClip[] vrBotVoice;
    public AudioClip[] vrBotVoice2;
    public AudioClip[] verdict;
    public AudioClip vrBotNice;
    public AudioClip forgetToCloseValve;


    // This method is for playing VRBot`s voice over
    public void PlaySubtitleVoiceOver(AudioClip audio)
    {
        subtitleSource.clip = audio;
        subtitleSource.Play();
        // Debug.Log("Voice is played");
    }
    public void StopSubtitleVoiceOver(AudioClip audio)
    {
        subtitleSource.clip = audio;
        subtitleSource.Stop();
        // Debug.Log("Voice is played");
    }

    // Background Music
    public void PlayBGMusic(AudioClip audio,bool state)
    {
        musicSource.clip = audio;
        if(state)
        {
            musicSource.Play();
        }
        else
        {
            musicSource.Stop();
        }
    }

    // SFX
    public void WhooseFireFX(bool state)
    {
        sfxSource.clip = whooseFire;
        if(state)
        {
            sfxSource.Play();
        }
        else
        {
            sfxSource.Stop();
        }
    }
    public void LighterFX(bool state)
    {
        sfxSource.clip = lighterFX;
        if(state)
        {
            sfxSource.Play();
        }
        else
        {
            sfxSource.Stop();
        }
        // Debug.Log("SFX is played");
    }
    
    public void DoorFX(bool state)
    {
        if(state)
        {
            sfxSource.clip = openDoorFX;
            sfxSource.Play();
        }
        else
        {
            sfxSource.clip = closeDoorFX;
            sfxSource.Play();
        }
        // Debug.Log("SFX is played");
    }
    public void CheckpointFX()
    {
        sfxSource.clip = checkpointFX;
        sfxSource.Play();
        // Debug.Log("SFX is played");
    }
    public void CollectedPointFX()
    {
        sfxSource.clip = collectedPointsFX;
        sfxSource.Play();
        // Debug.Log("SFX is played");
    }
    public void VRBotNice()
    {
        subtitleSource.clip = vrBotNice;
        subtitleSource.Play();
        // Debug.Log("voice over is played");
    }
    public void ForgetToCloseValve()
    {
        subtitleSource.clip = forgetToCloseValve;
        subtitleSource.Play();
        // Debug.Log("voice over is played");
    }

    public void PlayPerformance(AudioClip audio)
    {
        subtitleSource.clip = audio;
        subtitleSource.Play();
        // Debug.Log("voice over is played");
    }
}