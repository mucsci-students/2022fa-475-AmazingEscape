using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSoundL1 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    AudioClip lastClip;
    public float MaxSilence = 30f;
    float timer;
    int random;
     

    void Start()
    {
        int random = Random.Range(0, 7);
    }

    void Update()
    {
        timer += (Time.deltaTime + random);
        if (timer > MaxSilence)
        {
            audioSource.PlayOneShot(RandomClip());
            timer = 0;
        }
    }

    AudioClip RandomClip()
    {
        int attempts = 3;
        AudioClip newClip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        while (newClip == lastClip && attempts > 0)
        {
            newClip = audioClipArray[Random.Range(0, audioClipArray.Length)];
            attempts--;
        }
        lastClip = newClip;
        return newClip;
    }
}
