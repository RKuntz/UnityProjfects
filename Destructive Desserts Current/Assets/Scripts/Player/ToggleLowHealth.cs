using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLowHealth : MonoBehaviour
{
    private GameObject musicManager;
    private LowHealthMusic lowHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindGameObjectWithTag("MusicManager");
        if (musicManager != null)
        {
            lowHealth = musicManager.GetComponent<LowHealthMusic>();
        }
    }

    public void ChangeHealth()
    {
        lowHealth.playerHealthLow = !lowHealth.playerHealthLow;
    }
}
