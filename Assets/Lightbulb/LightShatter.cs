using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class LightShatter : MonoBehaviour
{
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider collider)
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        //Wait for 2 seconds
        yield return new WaitForSeconds(0.5f);
        GetComponent<Light>().enabled = false;
    }
}
