using UnityEngine;

public class ItemTriggerEffect : InteractEffect
{
    //Get Interact Reference
    //Invoke Action
    [SerializeField] Interact _objectToTrigger;
    public override void InteractEvent()
    {
        _objectToTrigger.OnInteract(false);
    }
}
