using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : GunBase
{
    [SerializeField] private Transform[] bulletPoint;
    [SerializeField] private BulletBase bulletPrefab;
    public override void Shoot()
    {
        base.Shoot();
        foreach (Transform t in bulletPoint)
        {
            //BulletBase bullet = Instantiate(bulletPrefab, t.position, t.rotation);
            BulletBase bullet = SimplePool.Spawn<BulletBase>(PoolType.Bullet_2, t.position, t.rotation);
            bullet.OnInit(10);
        }
        
    }
}
