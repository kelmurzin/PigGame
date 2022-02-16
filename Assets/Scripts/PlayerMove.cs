using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public ControlType controlType;
    public Joystick joystick;

    public enum ControlType
    {
        PC, Android
    }
 
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;

    private Rigidbody2D _rb;
    private Vector2 _movement;

    private void Start() => _rb = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (controlType == ControlType.PC)
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
        }

        else if (controlType == ControlType.Android)
        {
            _movement.x = joystick.Horizontal;
            _movement.y = joystick.Vertical;
        }

        _animator.SetFloat("Horizontal", _movement.x);
        _animator.SetFloat("Vertical", _movement.y);
    }

    private void FixedUpdate() => _rb.MovePosition(_rb.position + _movement * _speed * Time.fixedDeltaTime);
}
