using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsound : MonoBehaviour
{
    public AudioClip spawnSound; // Drag & drop the audio clip in the Unity Editor
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = spawnSound;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
