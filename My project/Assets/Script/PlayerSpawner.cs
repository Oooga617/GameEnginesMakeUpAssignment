using UnityEngine;

public class PlayerSpawner : Spawner
{
    public GameObject playerObj;
    public override GameObject spawnEntity()
    {
        Instantiate(playerObj, this.transform.position, Quaternion.identity);
        return playerObj.GetComponent<GameObject>();
    }
}
