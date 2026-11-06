using Random = UnityEngine.Random;
using Unity.Mathematics;
using UnityEngine;

public class FruitSpawner : Spawner
{
    public GameObject Cherry, Star, Diamond;
    int pickOneItem = 0;
    GameObject fruitGameObj;
    public override GameObject spawnEntity()
    {
        pickOneItem = Random.Range(0, 3);
        switch (pickOneItem)
        {
            case 0:
                fruitGameObj = Cherry;
                break;
            case 1:
                fruitGameObj = Star;
                break;
            case 2:
                fruitGameObj = Diamond;
                break;
        }

        Vector3 coordinates = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(2.0f, -5.0f), 0);
        Instantiate(fruitGameObj, coordinates, quaternion.identity);
        return fruitGameObj.GetComponent<GameObject>();


    }
}
