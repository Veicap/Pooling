using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUnit : MonoBehaviour
{
    public PoolType PoolType;
    private Transform tf;
    public Transform TF
    {
    get
        {
            if(tf == null)
            {
                tf = transform;
            }
            return tf;
        }
    }
}

public enum PoolType
{
    Bullet_1 = 0,
    Bullet_2 = 1,
    Bullet_3 = 2,
} 
