using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMannequin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ("Player"))       
            Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
