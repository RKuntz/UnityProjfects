using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision player)
    {
        SceneManager.LoadScene("LevelOne");
    }
}
