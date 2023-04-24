using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public GameObject goal;
    public NavMeshAgent enemy;
    public bool stunned = false;


    public void Start()
    {
        
    }

    private void Update()
    {
        if (!stunned)
        {
            enemy.destination = goal.transform.position;
        }
    }
}