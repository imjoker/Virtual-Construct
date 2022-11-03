using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag ("Player"))
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
