using System;
using UnityEngine;

public abstract class Interact : MonoBehaviour
{
    [field: SerializeField] public bool IsInteractable {get; private set;} = true;
    public Action InteractHandler;
    IInteractEffect[] effects;
    void Awake() 
    {
        GetEvents();
    }

    public abstract void OnInteract(bool isPlayer);

    protected void GetEvents()
    {
        effects = GetComponents<IInteractEffect>();
        for(int i = 0; i < effects.Length; i++)
            InteractHandler += effects[i].InteractEvent;
    }

    void OnDisable() 
    {
        for(int i = 0; i < effects.Length; i++)
            InteractHandler -= effects[i].InteractEvent;
    }
}
