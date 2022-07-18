using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]

public class AnimationPlayer : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private string _speedAnimator = "Speed";

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    public void StartMoveAnimation(float movment)
    {
        _animator.SetFloat(_speedAnimator, 1);
        _spriteRenderer.flipX = movment < 0;
    }

    public void StoptMoveAnimation()
    {
        _animator.SetFloat(_speedAnimator, 0);
    }
}
