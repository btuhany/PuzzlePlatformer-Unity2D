using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : SingletonObject<FruitManager> 
{
    Dictionary<Fruits, int> _fruits = new Dictionary<Fruits, int>();
    private void Awake()
    {
        SingletonThisObject(this);
        _fruits.Add(Fruits.Banana, 0);
        _fruits.Add(Fruits.Pineapple, 0);
        _fruits.Add(Fruits.Melon, 0);
    }
    public int GetFruitNumber(Fruits fruit)
    {
        return _fruits[fruit];
    }
    public bool AreThereEnoughFruit(Fruits fruit, int limit)
    {
        if (_fruits[fruit] >= limit)
        {
            return true;
        }
        else
        {
            return false;
        }
            
    }
    public void IncreaseFruitNumber(Fruits fruit)
    {
        _fruits[fruit]++;
    }
    public void DecreaseFruitNumber(Fruits fruit, int number)
    {
        _fruits[fruit]= _fruits[fruit] - number;
        if (_fruits[fruit] < 0)
        {
            _fruits[fruit] = 0;
        }
    }
    private void Update()
    {
        //Delete update
        Debug.Log("-------------------------------");
        Debug.Log("-------------------------------");
        Debug.Log("-------------------------------");
        Debug.Log("-------------------------------");
        Debug.Log("-------------------------------");
        Debug.Log("Melon " + _fruits[Fruits.Melon]);
        Debug.Log("Banana" + _fruits[Fruits.Banana]);
        Debug.Log("Pineapple" + _fruits[Fruits.Pineapple]);

    }
}
