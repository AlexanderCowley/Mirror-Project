using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ToggleAnimationEffect : MonoBehaviour, IInteractEffect
{
    Animator _animator;
    [SerializeField] string AnimName;
    [SerializeField] string AnimName2;
    int _animStateHash;
    int _animStateHash2;
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
        
        _animStateHash = Animator.StringToHash("Base Layer."+ AnimName);
        //Avoids setting the hash to _animStateHash2 initally
        _currentHash = _animStateHash;
        
        if(AnimName2 != string.Empty)
            _animStateHash2 = Animator.StringToHash("Base Layer."+ AnimName2);
        else
            _animStateHash2 = _animStateHash;
    }
    
    public void InteractEvent()
    {
        PlayAnimation();
    }

    void PlayAnimation()
    {
        if(_invalidStateName)
            return;
        //Plays the animation
        _animator.CrossFade(_currentHash, 0f, 0);
        //Sets the hash for the next animation
        _currentHash = _currentHash != _animStateHash ? _animStateHash : _animStateHash2;
    }
}
