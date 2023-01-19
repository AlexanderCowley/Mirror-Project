using UnityEngine;

public class ItemTriggerEffect : MonoBehaviour, IInteractEffect
{
    //Get Interact Reference
    //Invoke Action
    [SerializeField] Interact _objectToTrigger;
    public void InteractEvent()
    {
        _objectToTrigger?.OnInteract(false);
    }
}
