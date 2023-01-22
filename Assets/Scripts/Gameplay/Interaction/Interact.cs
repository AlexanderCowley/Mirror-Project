using System;
using UnityEngine;

public abstract class Interact : MonoBehaviour
{
    [field: SerializeField] public bool IsInteractable {get; private set;} = true;
    [field: SerializeField] public bool OneTimeUse {get; private set;} = false;
    public Action InteractHandler;
    IInteractEffect[] effects;
    void Awake() 
    {
        GetEvents();
    }

    //Interaction Implementation method
    public void OnInteract(bool isPlayer)
    {
        //Prevents players from interacting with objects that are triggered elsewhere
        if(!IsInteractable && isPlayer)
            return;
        InteractHandler?.Invoke();
        //If OneTimeUse is true unsubscribe all effects
        if(OneTimeUse)
            UnregisterEffects();
    }

    //Get all IInteractEffects on object and subscibe them to InteractHandler event
    protected void GetEvents()
    {
        effects = GetComponents<IInteractEffect>();
        for(int i = 0; i < effects.Length; i++)
            InteractHandler += effects[i].InteractEvent;
    }

    protected void UnregisterEffects()
    {
        //Unsubscribes all events from the InteractHandler
        for(int i = 0; i < effects.Length; i++)
            InteractHandler -= effects[i].InteractEvent;
    }

    //Ensures all effects are unsubscribed from the InteractHandler
    void OnDisable() 
    {
        UnregisterEffects();
    }
}
