using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    [SerializeField] float timeFrame;
    private float counter;
    private void Awake()
    {
        counter = 0;
    }

    private void Update()
    {
        counter -= Time.deltaTime;
        if(counter < 0)
        {
            Shoot();
            counter = timeFrame;
        }

    }

    public virtual void Shoot()
    {

    }

}
