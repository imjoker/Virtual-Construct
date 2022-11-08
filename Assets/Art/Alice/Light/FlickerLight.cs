using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{

    Light light;

    float minSpeed = 0.1f;
    float maxSpeed = 0.5f;
    float minIntensity = 0.01f;
    float maxIntensity = 0.2f;
    void Start()
    {
        light = GetComponent<Light>();
        StartCoroutine(run());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator run()
    {
        while (true)
        {
            light.enabled = true;
            light.intensity = Random.Range(minIntensity, maxIntensity);
            yield return new WaitForSeconds(Random.Range(minSpeed,maxSpeed)) ;
            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
        }
    }
}
