using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3;

    public void Start()
    {
        src.clip = sfx1;
        src.Play();
    }

    public void Jump()
    {
        src.clip = sfx2;
        src.Play();
    }

    public void EnterHole()
    {
        src.clip = sfx3;
        src.Play();
    }
}
