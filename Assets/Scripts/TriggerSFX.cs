using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource trash_audio;

    private void OnTriggerEnter (Collider other)
    {
        if (!trash_audio.isPlaying)
            trash_audio.Play();
    }
}
