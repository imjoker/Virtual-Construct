using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource audio;

    private void OnTriggerEnter (Collider other)
    {
        audio.Play();
    }
}
