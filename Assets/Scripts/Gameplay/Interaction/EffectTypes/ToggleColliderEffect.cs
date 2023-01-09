using UnityEngine;

public class ToggleColliderEffect : InteractEffect
{
    Collider _collider;
    void Awake() => _collider = GetComponent<Collider>();

    public override void InteractEvent()
    {
        ToggleCollider();
    }

    void ToggleCollider()
    {
        _collider.isTrigger = !_collider.isTrigger;
    }
}
