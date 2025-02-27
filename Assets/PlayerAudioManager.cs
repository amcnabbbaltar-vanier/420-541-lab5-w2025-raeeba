using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerAudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPunchSound()
    {
        audioSource.Play();
    }
}
