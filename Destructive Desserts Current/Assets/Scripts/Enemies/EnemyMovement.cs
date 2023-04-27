using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public GameObject goal;
    public NavMeshAgent enemy;
    public bool stunned = false;
    private float distance;


    public void Start()
    {
        enemy = gameObject.GetComponent<NavMeshAgent>();
        goal = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (!stunned)
        {
            enemy.speed = 5;
            enemy.destination = goal.transform.position;
        }else
        {
            enemy.speed = 0;
        }

        distance = Vector3.Distance(gameObject.transform.position, goal.transform.position);
        if (distance < 2)
        {
            enemy.speed = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            stunned = true;
            Debug.Log("Collision based stun.");
        }
    }
}