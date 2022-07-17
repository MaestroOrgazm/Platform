using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]


public class PlayerControl : MonoBehaviour
{
    private float _speed = 2;
    private float _jump = 9;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private string _speedAnimator = "Speed";

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float movment = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movment, 0, 0) * _speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rigidbody2D.velocity.y) < 0.05f)
        {
            _rigidbody2D.AddForce(new Vector2(0, _jump), ForceMode2D.Impulse);
        }

        if (movment != 0)
        {
             _animator.SetFloat(_speedAnimator, 1);
            _spriteRenderer.flipX = movment < 0;
        }
        else
        {
            _animator.SetFloat(_speedAnimator, 0);
        }
    }
}
