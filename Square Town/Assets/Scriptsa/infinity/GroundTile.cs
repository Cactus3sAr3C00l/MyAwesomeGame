
using UnityEngine;

public class GroundTile : MonoBehaviour
{


    GroundSpawner groundspawner;

    public GameObject obstaclePrefab, obstablePrefab2, obstaclePrefab3, obstaclePrefab4, obstaclePrefab5, coinPrefab;
    void Start()
    {
        groundspawner = GameObject.FindObjectOfType<GroundSpawner>();

        SpawnCoins();

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
            Instantiate(obstablePrefab2, spawnPoint.position, obstablePrefab2.transform.rotation);
           
        }
        else if (obstacleSpawnIndex > 15 && obstacleSpawnIndex < 26)
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
            Instantiate(obstaclePrefab3, spawnPoint.position ,obstaclePrefab3.transform.rotation);
            
        }
        else if (obstacleSpawnIndex < 15 &&   obstacleSpawnIndex > 10)
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
             Instantiate(obstaclePrefab4, spawnPoint.position, obstaclePrefab4.transform.rotation);
            
        }
        else if (obstacleSpawnIndex < 28 && obstacleSpawnIndex > 26 )
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
           Instantiate(obstaclePrefab4, spawnPoint.position, obstaclePrefab4.transform.rotation);
           
        }
        else if(obstacleSpawnIndex<37 && obstacleSpawnIndex > 28)
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

           Instantiate(obstaclePrefab.transform, spawnPoint.position, obstaclePrefab.transform.rotation);
            
        }
        else if (obstacleSpawnIndex >36 )
        {
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

            Instantiate(obstaclePrefab5.transform, spawnPoint.position, obstaclePrefab5.transform.rotation);
        }
       


    }
   void SpawnCoins()
    {
       
      
            GameObject temp = Instantiate(coinPrefab);
            temp.transform.position = GetRandomPoint(GetComponent<Collider>());
       


    }
    Vector3 GetRandomPoint(Collider collider)
    {
        Vector3 point = new Vector3(
           Random.Range(collider.bounds.min.x,
           collider.bounds.max.x
           ),
             Random.Range(collider.bounds.min.y,
           collider.bounds.max.y
           ),
               Random.Range(collider.bounds.min.z,
           collider.bounds.max.z
           )

            );
        if(point != collider.ClosestPoint(point))
        {
            point =  GetRandomPoint(collider);
        }
        point.y = 1;
        return point;
    }
    
}
