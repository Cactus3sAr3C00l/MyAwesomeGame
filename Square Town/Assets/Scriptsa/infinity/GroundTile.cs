
using UnityEngine;

public class GroundTile : MonoBehaviour
{


    GroundSpawner groundspawner;
   
    public GameObject obstaclePrefab, obstablePrefab2, obstaclePrefab3, obstaclePrefab4, obstaclePrefab5;
    void Start()
    {
        groundspawner = GameObject.FindObjectOfType<GroundSpawner>();
        


    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        
         groundspawner.SpawnTile(true);
     
        Destroy(gameObject, 2f);
        
    }
    private void Update()
    {
        
    }
   
    public void SpawnObstacle(bool tak)
    {
        

        int obstacleSpawnIndex = Random.Range(2, 46);
        if ((obstacleSpawnIndex == 5 || obstacleSpawnIndex == 44 ) && tak )
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
            Instantiate(obstablePrefab2, spawnPoint.position, Quaternion.identity, transform);


        }
        else if (obstacleSpawnIndex > 15 && obstacleSpawnIndex < 26)
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
            Instantiate(obstaclePrefab3, spawnPoint.position, Quaternion.Euler(90f, 90f, 0f), transform);
        }
        else if (obstacleSpawnIndex < 15 &&   obstacleSpawnIndex > 10)
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
            Instantiate(obstaclePrefab4, spawnPoint.position, Quaternion.identity, transform);
        }
        else if (obstacleSpawnIndex < 28 && obstacleSpawnIndex > 26 )
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
            Instantiate(obstaclePrefab4, spawnPoint.position, Quaternion.identity, transform);
        }
        else if(obstacleSpawnIndex<37 && obstacleSpawnIndex > 28)
        {
           
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
           
            Instantiate(obstaclePrefab.transform.GetChild(0), spawnPoint.position, Quaternion.Euler(0, 180f,90f), transform);
        }
        else if (obstacleSpawnIndex >36 )
        {
            Debug.Log("Nic22");
        }
        else 
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
            Instantiate(obstaclePrefab3, spawnPoint.position, Quaternion.Euler(90f, 90f, 0f), transform);
        }


    }
   
    
}
