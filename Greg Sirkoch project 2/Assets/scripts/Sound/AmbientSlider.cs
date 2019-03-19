using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmbientSlider : MonoBehaviour
{
    public Slider slider;
    public AudioSource ambientsource;

    //Sets slider to the Playerpref value and saves the value as a player pref
    private void Start()
    {
        if (!PlayerPrefs.HasKey("Aslider"))
        {
            PlayerPrefs.SetFloat("Aslider", 1.0f);
        }
        slider.value = PlayerPrefs.GetFloat("Aslider");
    }


    void Update()
    {
        PlayerPrefs.SetFloat("Aslider", slider.value);
        ambientsource.volume = PlayerPrefs.GetFloat("Aslider");
    }
}
