using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    [SerializeField] private int _bulletCount;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _bulletCount; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        }        
    }
}
