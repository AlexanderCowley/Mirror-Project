using UnityEngine;
[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
    Animator _animator;
    static readonly int idle = Animator.StringToHash("Idle");
    static readonly int walk = Animator.StringToHash("Walk");
    void Awake() => _animator = GetComponent<Animator>();

    void UpdateMoveAnimation() => _animator.CrossFade(GetMoveState(), 0, 0);

    int GetMoveState() => Input.GetAxis("Horizontal") == 0 ? idle : walk;

    void Update() => UpdateMoveAnimation();
}
