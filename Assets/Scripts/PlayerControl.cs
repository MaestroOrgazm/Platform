using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class PlayerControl : MonoBehaviour
{
    private float _speed = 2;
    private float _jump = 9;
    private Transform _transform;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float Movment = Input.GetAxis("Horizontal");
        _transform.position += new Vector3(Movment, 0, 0) * _speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rigidbody2D.velocity.y) < 0.05f)
        {
            _rigidbody2D.AddForce(new Vector2(0, _jump), ForceMode2D.Impulse);
        }

        if (Movment != 0)
        {
             _animator.SetFloat("Speed",1);
            _spriteRenderer.flipX = Movment < 0 ? true : false;
        }
        else
        {
            _animator.SetFloat("Speed", 0);
        }
    }
}
