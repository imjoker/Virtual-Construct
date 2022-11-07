using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerAudioMgr : MonoBehaviour
{

    public Transform    player;
    private AudioSource  computerAudio;
    public AudioClip    startClip;
    public AudioClip[]  encourageAudioClips;
    public AudioClip[]  congratsAudioClips;
    public Transform[]  mannequins;
    private int         currMannequinNdx = 0;
    private float       timer = 0.0f;
    private Vector3     prevPos;
    public  float       minSpeed = 1.0f;

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
                if (((player.position.z - prevPos.z) / timer) < minSpeed)
                {
                    computerAudio.clip = encourageAudioClips[Random.Range(0, encourageAudioClips.Length)];
                    computerAudio.Play();
                }                               
            }
        }

        if (player.position.z > mannequins[currMannequinNdx].position.z)
        {
            computerAudio.clip = congratsAudioClips[Random.Range(0, congratsAudioClips.Length)];
            computerAudio.Play();
            ++currMannequinNdx;
        }

    }
}
