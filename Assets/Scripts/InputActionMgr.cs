using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class InputActionMgr : MonoBehaviour
{
    public  InputActionProperty startGame;
    public  Transform           computer;
    public  Transform           player;
    public AudioSource          computerAudio;
    public AudioClip            endClip;
    private float               timer = 3.0f;

    // Update is called once per frame
    void Update ()
    {
        if ((computer.position.z - player.position.z) < 3)
        {
            if (startGame.action.IsPressed())
            {
                player.rotation = Quaternion.Euler(0, 180, 0);

                SceneManager.LoadScene("Phase-2");
            } else {

                computerAudio.clip = endClip;

                if (!computerAudio.isPlaying)
                {
                    timer += Time.deltaTime;

                    if (timer > 3f)
                    {
                        computerAudio.Play();
                        timer = 0.0f;
                    }
                }
            }
        }
    }
}
