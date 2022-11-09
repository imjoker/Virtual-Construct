using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCongrats : MonoBehaviour
{
    public AudioSource congo_audio;
    public AudioClip   congo_clip;

    private void OnTriggerEnter (Collider other)
    {
        if (!congo_audio.isPlaying)
        {
            congo_audio.clip = congo_clip;
            congo_audio.Play();
        }
    }
}
