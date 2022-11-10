using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource trash_audio;
    public Image       activate_img;

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (!trash_audio.isPlaying)
            trash_audio.Play();

        if (!activate_img.IsActive ())
            activate_img.gameObject.SetActive(true);
    }
}
