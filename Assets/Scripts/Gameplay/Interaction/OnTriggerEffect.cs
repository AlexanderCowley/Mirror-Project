using UnityEngine;
[RequireComponent(typeof(OnTriggerInteract))]
public class OnTriggerEffect : MonoBehaviour
{
    OnTriggerInteract _interact;
    protected PlayerInteract PlayerInter;

    void Awake() 
    {
        _interact = GetComponent<OnTriggerInteract>();
    }

    public void SetInteract(PlayerInteract interact)
    {
        PlayerInter = interact;
    }
}