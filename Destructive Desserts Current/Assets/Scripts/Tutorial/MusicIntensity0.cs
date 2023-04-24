using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicIntensity0 : MonoBehaviour
{
    public AudioMixerSnapshot intensity0;

    // Start is called before the first frame update
    void Start()
    {
        intensity0.TransitionTo(0.01f);
    }

}
