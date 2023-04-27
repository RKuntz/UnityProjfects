using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralObstacles : MonoBehaviour
{
    public GameObject smallObstaclePrefab;
    public GameObject largeObstaclePrefab;
    public GameObject[] smallSpawnPositions;
    public GameObject largeSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < smallSpawnPositions.Length; i++)
        {
            int chance = Random.Range(1, 3);
            //int chance = 2;
            Debug.Log(chance);
            if (chance == 2)
            {
                Instantiate(smallObstaclePrefab, smallSpawnPositions[i].transform.position, Quaternion.identity);
            }
        }

        int largeObstacleChance = Random.Range(1, 4);
        //int largeObstacleChance = 3;
        Debug.Log(largeObstacleChance);
        if (largeObstacleChance == 3)
        {
            Instantiate(largeObstaclePrefab);
        }
        
    }

}
