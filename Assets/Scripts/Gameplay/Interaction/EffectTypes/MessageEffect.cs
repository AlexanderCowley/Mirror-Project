using UnityEngine;
public class MessageEffect : InteractEffect
{
    [SerializeField] string Message;
    public override void InteractEvent()
    {
        Debug.Log(Message);
    }
}
