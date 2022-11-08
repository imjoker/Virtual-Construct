using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMannequin : MonoBehaviour
{

    public GameObject block;
    public int        health = 5;
    public Vector3    sub    = new Vector3(0.1f, 0.1f, 0.1f);

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
                float x;
                float y;
                float z;

            x = this.gameObject.transform.position.x;
            y = this.gameObject.transform.position.y;
            z = this.gameObject.transform.position.z;

            --health;

            if (health == 0)
                Destroy(this.gameObject);
            else
                this.gameObject.transform.localScale -= sub;
                            
        }
    }

}
