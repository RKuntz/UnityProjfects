using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BackgroundMusicManager : MonoBehaviour
{
    public GameObject TimerObject;
    public Timer timer;
    public int intensity = 1;
    public AudioMixerSnapshot[] musicStates;
    // Start is called before the first frame update
    void Start()
    {
        timer = TimerObject.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer.timePassed >= 15 && timer.timePassed <30 && intensity != 2)
        {
            musicShift(2);
            intensity = 2;
        }

        if (timer.timePassed >= 30 && timer.timePassed < 60 && intensity != 3)
        {
            musicShift(3);
            intensity = 3;
        }

        if (timer.timePassed >= 60 && intensity != 4)
        {
            musicShift(4);
            intensity = 4;
        }

    }

    private void musicShift(int intensity)
    {
        switch (intensity)
        {
            case 2:
                Debug.Log("Time for intensity 2!");
                break;

            case 3:
                Debug.Log("Cranking up the heat! Intensity 3!");
                break;

            case 4:
                Debug.Log("Things are getting hot! Intensity 4!");
                break;

            default:
                Debug.Log("Nothing to worry about. Intensity 1.");
                break;
        }
        intensity -= 1;
        musicStates[intensity].TransitionTo(0.5f);
    }
}
