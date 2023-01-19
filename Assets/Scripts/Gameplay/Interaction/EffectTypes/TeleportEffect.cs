using UnityEngine;

public class TeleportEffect : OnTriggerEffect, IInteractEffect
{
    Transform _targetTransform;
    Transform _moveTransform;
    CharacterController _controller;

    void Awake() 
    {
        _targetTransform = transform.GetChild(0).GetComponent<Transform>();
    }

    void MoveObject()
    {
        _controller = PlayerInter.GetComponent<CharacterController>();

        //CharacterController overrides the gameobject's transform
        //Disables the controller before assigning the transform
        _controller.enabled = false;
        _moveTransform = PlayerInter.transform;
        _moveTransform.position = _targetTransform.position;
        //Renables player movement
        _controller.enabled = true;
        //Dereferenced _controller to ensure that the player's
        //controller is not accidently disabled
        _controller = null;
        _moveTransform = null;
    }

    public void InteractEvent()
    {
        MoveObject();
    }
}
