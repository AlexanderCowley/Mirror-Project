using UnityEngine;
public class MessageEffect : InteractEffects
{
    [SerializeField] string Message;
    public override void InteractEvent()
    {
        Debug.Log(Message);
    }
}
