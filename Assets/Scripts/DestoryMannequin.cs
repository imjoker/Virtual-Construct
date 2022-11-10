using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestoryMannequin : MonoBehaviour
{

    public GameObject block;
    public int        health = 2;
    public Vector3    sub    = new Vector3(0.05f, 0.05f, 0.05f);
    public AudioSource audio_source;
    public AudioClip   audio_clip;
    public AudioClip   hit_clip;
    public Image       activate_img;

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

                activate_img.gameObject.SetActive(false);

                Instantiate(block);

                audio_source.clip = audio_clip;
                audio_source.Play();

            } else
            {
                Debug.Log("hit");

                audio_source.clip = hit_clip;
                audio_source.Play();

                this.gameObject.transform.localScale -= sub;
            }
        }
    }

}
