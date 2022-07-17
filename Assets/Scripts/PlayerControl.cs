using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]


public class PlayerControl : MonoBehaviour
{
    public float Movment { get; private set; }
    private float _speed = 2;
    private float _jump = 9;
    private Rigidbody2D _rigidbody2D;
    private float _limit = 0.05f;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movment = Input.GetAxis("Horizontal");
        transform.position += new Vector3(Movment, 0, 0) * _speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rigidbody2D.velocity.y) < _limit)
        {
            _rigidbody2D.AddForce(new Vector2(0, _jump), ForceMode2D.Impulse);
        }
    }
}
