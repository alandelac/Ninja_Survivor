using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class controlMusic : MonoBehaviour
{
    public AudioSource start;
    public AudioSource loop;
    void Start()
    {
        start.Play();
        loop.PlayDelayed(start.clip.length);
    }

    
}