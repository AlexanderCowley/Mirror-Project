using UnityEngine;

public class ToggleColliderEffect : MonoBehaviour, IInteractEffect
{
    Collider _collider;
    void Awake() => _collider = GetComponent<Collider>();

    public void InteractEvent()
    {
        ToggleCollider();
    }

    void ToggleCollider()
    {
        _collider.isTrigger = !_collider.isTrigger;
    }
}
