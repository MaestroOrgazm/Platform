using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(PlayerControl))]

public class AnimationPlayer : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private string _speedAnimator = "Speed";
    private PlayerControl _playerControl;
    private float _movment;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        _playerControl = GetComponent<PlayerControl>();
        _movment = _playerControl.Movment;
    }

    private void Update()
    {
        if (_movment != 0)
        {
            _animator.SetFloat(_speedAnimator, 1);
            _spriteRenderer.flipX = _movment < 0;
        }
        else
        {
            _animator.SetFloat(_speedAnimator, 0);
        }
    }

}
