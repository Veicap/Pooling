using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun3 : GunBase
{
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private BulletBase bulletPrefab;
    public override void Shoot()
    {
        base.Shoot();
        StartCoroutine(IESpawnBullet());
    }

    private IEnumerator IESpawnBullet()
    {
        for (int i = 0; i < 3; i ++)
        {
            //BulletBase bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            BulletBase bullet = SimplePool.Spawn<BulletBase>(PoolType.Bullet_3, bulletPoint.position, bulletPoint.rotation);
            bullet.OnInit(10);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
