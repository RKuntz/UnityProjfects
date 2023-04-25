using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLowHealth : MonoBehaviour
{
    private GameObject musicManager;
    private IsRightHand hand;
    private LowHealthMusic lowHealth;
    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindGameObjectWithTag("MusicManager");
        if (musicManager != null)
        {
            lowHealth = musicManager.GetComponent<LowHealthMusic>();
        }
        else
        {
            enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        hand = collision.gameObject.GetComponent<IsRightHand>();
        if(hand != null)
        {
            lowHealth.playerHealthLow = true;
        }
        else
        {
            enabled = false;
        }
    }
}
