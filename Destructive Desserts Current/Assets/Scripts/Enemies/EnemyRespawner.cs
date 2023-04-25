using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject[] spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemies.Length <= 0)
        {
            if (timer >= 3)
            {
                for (int i = 0; i < spawnPos.Length; i++)
                {
                    Instantiate(enemy, spawnPos[i].transform.position, Quaternion.identity);
                }
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }

}
