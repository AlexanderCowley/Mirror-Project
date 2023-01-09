using UnityEngine;

public class AnimationEffect : InteractEffect
{
    Animator _animator;

    void Awake() 
    {
        _animator = GetComponent<Animator>();
    }
    
    public override void InteractEvent()
    {
        PlayAnimation();
    }

    void PlayAnimation()
    {
        Debug.Log("Play Anim Here");
    }
}
