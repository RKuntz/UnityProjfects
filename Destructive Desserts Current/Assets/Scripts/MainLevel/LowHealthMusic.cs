using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LowHealthMusic : MonoBehaviour
{
    public bool playerHealthLow = false;
    public AudioMixerSnapshot lowHealth;
    public AudioMixerSnapshot goodHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealthLow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealthLow)
        {
            lowHealth.TransitionTo(0.3f);
        }
        else
        {
            goodHealth.TransitionTo(0.3f);
        }
    }
}
