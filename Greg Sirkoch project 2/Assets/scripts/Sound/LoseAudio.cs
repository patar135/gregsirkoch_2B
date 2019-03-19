using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseAudio : MonoBehaviour
{

    public AudioSource loseSource;
    public AudioClip Badnoise;
    
    
    //Audio for when you lose the game
    void Start()
    {
        loseSource.clip = Badnoise;
        loseSource.Play();
    }

 
}
