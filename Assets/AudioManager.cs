using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------- Audio Clip -------")]
    public AudioClip background;
    public AudioClip startButton;
    public AudioClip jump;
    public AudioClip enterHole;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
    // public AudioSource src;
    // public AudioClip sfx1, sfx2, sfx3, music;

    // public void Start()
    // {
    //     src.clip = sfx1;
    //     src.Play();
    // }

    // public void Jump()
    // {
    //     src.clip = sfx2;
    //     src.Play();
    // }

    // public void EnterHole()
    // {
    //     src.clip = sfx3;
    //     src.Play();
    // }

    // private void Background()
    // {
    //     src.clip = music;
    //     src.Play();
    // }
    
}
