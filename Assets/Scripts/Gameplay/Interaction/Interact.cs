using System;
using UnityEngine;

[DisallowMultipleComponent]
public class Interact : MonoBehaviour
{
    public Action InteractHandler;
    void Awake() 
    {
        GetEvents();
    }
    
    public void OnInteract() => InteractHandler?.Invoke();

    void GetEvents()
    {
        InteractEffect[] effects = GetComponents<InteractEffect>();
        for(int i = 0; i < effects.Length; i++)
            InteractHandler += effects[i].InteractEvent;
    }
}
