using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmpAudioMgr : MonoBehaviour
{

    public Transform player;
    private AudioSource computerAudio;
    public AudioClip startClip;
    public AudioClip[] encourageAudioClips;
    private float timer = 0.0f;
    private Vector3 prevPos;
    public float minSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        computerAudio = GetComponent<AudioSource>();
        computerAudio.clip = startClip;
        computerAudio.Play();
        prevPos = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3.0f)
        {
            timer = 0.0f;
            prevPos = player.position;

            if (!computerAudio.isPlaying)
            {
                Debug.Log("Audio not playing yet!");

                if (((player.position.z - prevPos.z) / timer) < minSpeed)
                {
                    Debug.Log("player not fast enoguh");

                    computerAudio.clip = encourageAudioClips[Random.Range(0, encourageAudioClips.Length)];
                    computerAudio.Play();
                }
            }
        }
    }
}
