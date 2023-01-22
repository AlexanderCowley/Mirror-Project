using UnityEngine;

public class OnTriggerInteract : Interact
{
    OnTriggerEffect[] _triggerEffects;

    void Awake() 
    {
        //Get all events to subscribe to
        GetEvents();
        //Get trigger events to set player interact
        GetOnTriggerEvents();
    }
    void OnTriggerEnter(Collider other) 
    {
        PlayerInteract interact = other.GetComponent<PlayerInteract>();
        bool isPlayer = interact != null;
        UpdateCollisionRef(interact);
        OnInteract(isPlayer);
    }
    
    void UpdateCollisionRef(PlayerInteract interact)
    {
        if(_triggerEffects.Length == 0)
            return;
        if(_triggerEffects.Length == 1)
        {
            _triggerEffects[0].SetInteract(interact);
            return;
        }

        for(int i = 0; i < _triggerEffects.Length; i++)
        {
            _triggerEffects[i].SetInteract(interact);
        }
    }

    void GetOnTriggerEvents()
    {
        //Filter _effects from base class to avoid second GetComponents call?
        _triggerEffects = GetComponents<OnTriggerEffect>();
    }
}
