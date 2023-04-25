using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySounds : MonoBehaviour
{
    private float timer;
    private int soundTime;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        soundTime = Random.Range(3, 7);
        Debug.Log("Sound off in " + soundTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= soundTime)
        {
            Debug.Log("Playing sound!");
            sound.Play();
            soundTime = Random.Range(7, 15);
            Debug.Log("Reshufled sound timer: " + soundTime);
            timer = 0;
        }
    }
}
