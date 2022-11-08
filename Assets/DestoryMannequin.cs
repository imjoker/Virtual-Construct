using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMannequin : MonoBehaviour
{
    private GameObject mannequin;
    // Start is called before the first frame update
    void Start()
    {
        mannequin = GetComponent<GameObject>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
