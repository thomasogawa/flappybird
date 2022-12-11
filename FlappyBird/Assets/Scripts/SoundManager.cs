using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource EffectsSource;
    public AudioSource MusicSource;
    
    
    public static SoundManager Instance { get; private set; }
    private void Awake() 
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }
    public void Play(AudioClip clip)
    {
        EffectsSource.clip = clip;
        EffectsSource.Play();
    }
    public void PlayMusic(AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }
}
