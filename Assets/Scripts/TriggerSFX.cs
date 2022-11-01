using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource trash_audio;

    private void OnTriggerEnter (Collider other)
    {
        trash_audio.Play();
    }
}
