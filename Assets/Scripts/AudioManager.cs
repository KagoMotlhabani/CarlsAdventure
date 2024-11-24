using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource ambianceSource;
    public AudioClip ambiance;
    public AudioClip music;
    public bool playingMusic = false;
    // Start is called before the first frame update
    void Start()
    {
        ambianceSource.clip = ambiance;
        ambianceSource.Play();
        musicSource.clip = music;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic(){
        musicSource.PlayOneShot(music);
    }

}
