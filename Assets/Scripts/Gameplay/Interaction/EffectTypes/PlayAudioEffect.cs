using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class PlayAudioEffect : MonoBehaviour, IInteractEffect
{
    AudioSource _audioSource;
    [SerializeField] AudioClip _clipToPlay;

    void Awake() 
    {
        _audioSource = GetComponent<AudioSource>();

        if(_audioSource.clip == null)
            _audioSource.clip = _clipToPlay;
    } 
    public void InteractEvent()
    {
        AudioManager.Instance.PlaySoundEffects(_audioSource);
    }
}
