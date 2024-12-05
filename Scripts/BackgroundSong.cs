using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSong : MonoBehaviour
{
    public AudioClip[] songs;
    public AudioSource source;

    void Start()
    {
        int r = Random.Range(0, 3);
        for (int i = 0; i < songs.Length; i++)
        {
            if (r==i)
            {
                source.clip = songs[i];
                source.Play();
            }
        }
    }

}
