using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    /*private void OnCollisionEnter(Collision collider)
    {
        Debug.Log("Next Scene!");
        SceneManager.LoadScene("LevelOne");

    }*/

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Next Scene!");
        SceneManager.LoadScene("LevelOne");
    }
}
