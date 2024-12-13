using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBase : GameUnit
{
    [SerializeField] private float speed;
    private float damage;

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * transform.up);
    }
    public void OnInit(float damage)
    {
        this.damage = damage;
    }
    public void OnDespawn()
    {
        //Destroy(gameObject);
        SimplePool.Despawn(this);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Wall"))
        {
            OnDespawn();
        }
    }
}
