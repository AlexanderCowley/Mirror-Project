using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationEffect : MonoBehaviour, IInteractEffect
{
    Animator _animator;
    [SerializeField] string AnimName = string.Empty;
    static int _animStateHash;
    bool _invalidStateName = false;
    void Awake() 
    {
        _animator = GetComponent<Animator>();
        if(AnimName == string.Empty)
        {
            Debug.LogError("The Animation State Name has not been filled out!", gameObject);
            _invalidStateName = true;
            return;
        }

        _animStateHash = Animator.StringToHash(AnimName);
    }
    
    public void InteractEvent()
    {
        PlayAnimation();
    }

    void PlayAnimation()
    {
        if(_invalidStateName)
            return;

        _animator.CrossFade(_animStateHash, 0f, 0);
    }
}
