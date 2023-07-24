using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    private float _moveInput;
    private float _speed = 3;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");

        _rigidbody.velocity = new Vector2(_moveInput * _speed, _rigidbody.velocity.y);

        if (_moveInput > 0)
            transform.rotation = Quaternion.Euler(0, 180, 0);
        else if (_moveInput < 0)
            transform.rotation = Quaternion.Euler(0, 0, 0);

        if (_moveInput == 0)
            _animator.SetBool("isRun", false);
        else
            _animator.SetBool("isRun", true);
    }
}
