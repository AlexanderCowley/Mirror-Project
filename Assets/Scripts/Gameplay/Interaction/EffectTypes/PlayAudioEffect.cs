using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class PlayAudioEffect : InteractEffect
{
    AudioSource _audioSource;
    [SerializeField] AudioClip _clipToPlay;

    void Awake() 
    {
        _audioSource = GetComponent<AudioSource>();

        if(_audioSource.clip == null)
            _audioSource.clip = _clipToPlay;
    } 
    public override void InteractEvent()
    {
        //AudioManager.Instance.PlayMusic(_audioSource);
    }
}
