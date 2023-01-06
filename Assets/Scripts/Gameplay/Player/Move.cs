using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Move : MonoBehaviour
{
    CharacterController _controller;
    [SerializeField] float Speed = 7;

    void Awake() => _controller = GetComponent<CharacterController>();
    void MoveCharacter()
    {
        float xAxis = Input.GetAxis("Horizontal");
        Vector3 MoveVector = new Vector3(Time.deltaTime * xAxis * Speed, 0, 0);
        _controller.Move(MoveVector);
    }

    void Update() => MoveCharacter();
}
