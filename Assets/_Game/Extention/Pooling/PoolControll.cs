using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolControll : MonoBehaviour
{
    [SerializeField] PoolAmount[] poolAmounts;
    private void Awake()
    {
        GameUnit[] gameUnits = Resources.LoadAll<GameUnit>("Pool/");
        Debug.Log(gameUnits.Length);
        foreach (var unit in gameUnits)
        {
            SimplePool.PreLoad(unit, 0, new GameObject(unit.name).transform);
        }
        for (int i = 0; i < poolAmounts.Length; i++)
        {
            SimplePool.PreLoad(poolAmounts[i].prefab, poolAmounts[i].amount, poolAmounts[i].parent);
        }
    }
}

[System.Serializable]
public class PoolAmount
{
    public GameUnit prefab;
    public Transform parent;
    public int amount;
}