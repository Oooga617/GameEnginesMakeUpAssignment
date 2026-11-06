using NUnit.Framework;
using UnityEngine;

public class FruitManager : Singleton<FruitManager>
{
    public FruitSpawner spawner;

    public void spawnFruit()
    {
        spawner.spawnEntity();
    }
}
