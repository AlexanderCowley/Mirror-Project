using UnityEngine;

public class Teleport : MonoBehaviour
{
    Transform _targetTransform;
    GameObject _objectToMove;
    Transform _moveTransform;

    CharacterController _controller;

    void Awake() 
    {
        _targetTransform = transform.GetChild(0).GetComponent<Transform>();
    }

    void MoveObject()
    {
        _moveTransform.position = _targetTransform.position;
        //Renables player movement
        _controller.enabled = true;
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<CharacterController>() == null)
            return;
        
        //CharacterController overrides the gameobject's transform
        //Disables the controller before assigning the transform
        _controller = other.GetComponent<CharacterController>(); 
        _controller.enabled = false;
        _moveTransform = other.transform;   
        MoveObject();
    }

    
}
