using Random = UnityEngine.Random;
using Unity.Mathematics;
using UnityEngine;

public class FruitSpawner : Spawner
{
    public GameObject fruitGameObj;
    public override GameObject spawnEntity()
    {
  
        Vector3 coordinates = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(2.0f, -5.0f), 0);
        Instantiate(fruitGameObj, coordinates, quaternion.identity);
        return fruitGameObj.GetComponent<GameObject>();


    }
}
