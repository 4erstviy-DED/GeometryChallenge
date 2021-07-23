using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioSource AudioS;

    public static int fixValue = 0;
   
    void Start()
    {
        AudioS = GetComponent<AudioSource>();
    }

    public static void MusicBegin()
    {
        AudioS.Play();
    }

    public static void MusicEnd()
    {
        AudioS.Stop();
    }

    public static void MusicPause()
    {
        AudioS.Pause();
    }

    public static void MusicUnPause()
    {
        AudioS.UnPause();
    }
}
