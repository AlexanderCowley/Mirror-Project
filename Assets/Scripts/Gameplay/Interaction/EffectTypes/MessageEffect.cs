using UnityEngine;
public class MessageEffect : MonoBehaviour, IInteractEffect
{
    [SerializeField] string Message;
    public void InteractEvent()
    {
        Debug.Log(Message);
    }
}
