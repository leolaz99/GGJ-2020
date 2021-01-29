using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChanger : MonoBehaviour
{
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        audioSource.volume = PlayerPrefs.GetFloat("SfxVolume") * PlayerPrefs.GetFloat("MasterVolume");        
    }
}
