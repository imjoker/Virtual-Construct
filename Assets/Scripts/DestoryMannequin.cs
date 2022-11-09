using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMannequin : MonoBehaviour
{

    public GameObject block;
    public int        health = 5;
    public Vector3    sub    = new Vector3(0.1f, 0.1f, 0.1f);
    public AudioSource audio_source;
    public AudioClip   audio_clip;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            --health;

            if (health == 0) {

                Vector3 position = this.gameObject.transform.position;

                position.x += 0.02f;
                position.y += 4.27f;
                position.z -= 0.02f;

                Destroy(this.gameObject);

                block.transform.position = position;

                Instantiate(block);

                audio_source.clip = audio_clip;
                audio_source.Play();

            } else
            {
                Debug.Log("hit");

                this.gameObject.transform.localScale -= sub;
            }
        }
    }

}
