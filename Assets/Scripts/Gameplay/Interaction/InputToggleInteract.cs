using UnityEngine;

public class InputToggleInteract : Interact
{
    public override void OnInteract(bool isPlayer)
    {
        if(!IsInteractable && isPlayer)
            return;
        
        InteractHandler?.Invoke();
    }
}