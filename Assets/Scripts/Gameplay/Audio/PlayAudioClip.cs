using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class PlayAudioClip : MonoBehaviour
{
    AudioSource _audioSource;
    [SerializeField] AudioClip _clipToPlay;

    void Awake() 
    {
        _audioSource = GetComponent<AudioSource>();

        if(_audioSource.clip == null)
            _audioSource.clip = _clipToPlay;
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<CharacterController>() != null)
            PlayClip();
    }

    public void PlayClip()
    {
        AudioManager.Instance.PlaySoundEffects(_audioSource);
    }
}
