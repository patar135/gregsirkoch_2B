using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXvolume : MonoBehaviour
{
    public float SFXvolumes;
    public Slider Slider;
    public Toggle Toggle;
    public bool muted;



    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


 


    //uses a slider and toggle to control SFX sound
    void Update()
    {


        if (muted == false)
        {
            SFXvolumes = PlayerPrefs.GetFloat("SFXslider");

        }
        else
        {
            SFXvolumes = 0f;
        }
     
    }
    public void MutedSFX (bool newValue)
    {
        muted = newValue;
    }
}
