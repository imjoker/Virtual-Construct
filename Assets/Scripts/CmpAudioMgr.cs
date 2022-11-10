using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmpAudioMgr : MonoBehaviour
{

    public Transform player;
    private AudioSource computerAudio;
    public AudioClip startClip;
    public AudioClip[] encourageAudioClips;
    public float timer = 0.0f;
    private Vector3 prevPos;
    public float minSpeed = 0.01f;
    private int audioNdx = 0;

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

        if (timer > 13f)
        {
            prevPos = player.position;

            if (!computerAudio.isPlaying)
            {
                Debug.Log("Audio not playing yet!");

                Debug.Log(player.position.z);
                Debug.Log(prevPos.z);
                Debug.Log((player.position.z - prevPos.z) / timer);

                if (((player.position.z - prevPos.z) / timer) < minSpeed)
                {
                    Debug.Log("player not fast enoguh");

                    computerAudio.clip = encourageAudioClips[audioNdx];
                    computerAudio.Play();

                    ++audioNdx;

                    if (audioNdx == encourageAudioClips.Length)
                        audioNdx = 0;
                }
            }

            timer = 0.0f;
        }
    }
}
