using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{

    Light flick_light;

    float minSpeed = 0.1f;
    float maxSpeed = 0.5f;
    float minIntensity = 0.01f;
    float maxIntensity = 15f;
    void Start()
    {
        flick_light = GetComponent<Light>();
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
            flick_light.enabled = true;
            flick_light.intensity = Random.Range(minIntensity, maxIntensity);
            yield return new WaitForSeconds(Random.Range(minSpeed,maxSpeed)) ;
            flick_light.enabled = false;
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
        }
    }
}
