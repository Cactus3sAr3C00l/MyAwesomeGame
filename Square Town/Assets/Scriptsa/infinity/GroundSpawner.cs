using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject groundTile;
    Vector3 nextSpawnPoint;


    public void SpawnTile(bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        bool tak =false;
        int random = Random.Range(1,3);
        if(random == 2)
        {
            tak = true;
        }
        if (spawnItems)
        {
            
            temp.GetComponent<GroundTile>().SpawnObstacle(tak);
            

        }
    }
    private void Start()
    {
        for (int i = 0; i <20; i++)
        {
            SpawnTile(false);
        }
    }

}
