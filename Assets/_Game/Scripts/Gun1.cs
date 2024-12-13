using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun1 : GunBase
{
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private BulletBase bulletPrefab;
    public override void Shoot()
    {
        base.Shoot();
        //BulletBase bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        BulletBase bullet = SimplePool.Spawn<BulletBase>(PoolType.Bullet_1, bulletPoint.position, bulletPoint.rotation);
        bullet.OnInit(10);
    }
}
