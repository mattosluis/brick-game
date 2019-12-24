using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private static SoundController instance;
    public AudioSource source;
    public AudioSource soundTrack;
    public AudioClip explosion;
    public AudioClip hitGround;
    public AudioClip breath;

    private void Awake()
    {
        instance = this;
    }

    public static void PlayExplosion()
    {
        instance.source.PlayOneShot(instance.explosion);
    }

    public static void PlayhitGround()
    {
        instance.source.PlayOneShot(instance.hitGround);
    }

    public static void PlayBreath()
    {
        instance.source.PlayOneShot(instance.breath);
    }

    public static void PlayMusic()
    {
        instance.soundTrack.Play();
    }

    public static void StopMusic()
    {
        instance.soundTrack.Stop();
    }
}
