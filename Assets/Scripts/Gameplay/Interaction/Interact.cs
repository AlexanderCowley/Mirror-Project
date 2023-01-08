using System;
using UnityEngine;

[DisallowMultipleComponent]
public class Interact : MonoBehaviour
{
    [field: SerializeField] public bool IsInteractable {get; private set;} = true;
    public Action InteractHandler;
    void Awake() 
    {
        GetEvents();
    }

    public void OnInteract(bool isPlayer)
    {
        if(!IsInteractable && isPlayer)
            return;
        
        InteractHandler?.Invoke();
    }

    void GetEvents()
    {
        InteractEffect[] effects = GetComponents<InteractEffect>();
        for(int i = 0; i < effects.Length; i++)
            InteractHandler += effects[i].InteractEvent;
    }
}
