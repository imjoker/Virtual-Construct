using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMannequin : MonoBehaviour
{

    public GameObject block;

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

            Destroy(this.gameObject);


        }
    }

}
