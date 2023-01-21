using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ToggleAnimationEffect : MonoBehaviour, IInteractEffect
{
    Animator _animator;
    [SerializeField] string AnimName;
    [SerializeField] string AnimName2;
    static int _animStateHash;
    static int _animStateHash2;
    int _currentHash = 0;
    bool _invalidStateName = false;
    void Awake() 
    {
        _animator = GetComponent<Animator>();

        if(AnimName == string.Empty)
        {
            Debug.LogError("The Animation Name Field is Empty!", gameObject);
            _invalidStateName = true;
            return;
        }
        _animStateHash = Animator.StringToHash(AnimName);
        _animStateHash2 = Animator.StringToHash(AnimName2);
    }
    
    public void InteractEvent()
    {
        PlayAnimation();
    }

    void PlayAnimation()
    {
        if(_invalidStateName)
            return;
        _currentHash = _currentHash == _animStateHash ? _animStateHash2 : _animStateHash;
        _animator.CrossFade(_currentHash, 0f, 0);
    }
}
