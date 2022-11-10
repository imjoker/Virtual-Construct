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
            if (congo_audio.GetComponent<CmpAudioMgr>().timer > 7f)
            {
                congo_audio.clip = congo_clip;
                congo_audio.Play();
            }

            congo_audio.GetComponent<CmpAudioMgr> ().timer = 0.0f;
        }
    }
}
