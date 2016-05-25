using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(AudioClip))]

public class SoundJump : MonoBehaviour
{
    public AudioClip clip;
    new AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            Debug.Log(1);
            audio.enabled = true;
            audio.PlayOneShot(clip, 1F);
        }
    }
}
