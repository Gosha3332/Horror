using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MovePlayer : MonoBehaviour
{
    public Joystick _jk;
    private CharacterController _ch;
    private Vector3 _move;
    [SerializeField] private float _speed = 10f;
    private void Start()
    {
        _ch = GetComponent<CharacterController>();
    }

    private void FixedUpdate() { Move(); }

    private void Move()
    {
        _move.y = -10;
        _move = _jk.Horizontal * transform.right + _jk.Vertical * transform.forward + _move.y * transform.up;
        _ch.Move(_move * _speed * Time.deltaTime);
    }
}
