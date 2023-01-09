using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static AudioManager _instance;
    public static AudioManager Instance
    {
        get{return _instance;}

        private set{ _instance = value; }
    }

    AudioSource _bgAudioSource;

    void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;

        DontDestroyOnLoad(Instance);
        _bgAudioSource = GetComponent<AudioSource>();
    }

    public void PlaySceneBG()
    {
        PlayMusic(_bgAudioSource);
    }

    public void PlayMusic(AudioSource audioSource)
    {
        audioSource?.Play();
    }

    public void SetBGVolume(float volumeLevel, float volumeBlendDuration)
    {

    }
}
