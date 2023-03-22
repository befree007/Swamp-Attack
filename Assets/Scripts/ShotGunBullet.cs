using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShotGunBullet : Bullet
{
    [SerializeField] private float _minRandomDirection;
    [SerializeField] private float _maxRandomDirection;
    private float _yPosition;

    private void Start()
    {
        _yPosition = Random.Range(_minRandomDirection, _maxRandomDirection);
    }

    public override void Direction()
    {
        _rigidbody2D.velocity = new Vector2(-_speed * Time.deltaTime, _yPosition);
    }
}
