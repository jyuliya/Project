using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(AudioClip))]

public class SoundCoin : MonoBehaviour {
    public AudioClip clip;
    new AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cylinder(Clone)")
        {
           
            audio.enabled = true;
            audio.PlayOneShot(clip, 1F);
        }
    }
}
