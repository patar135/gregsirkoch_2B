using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveSlider : MonoBehaviour
{
    public Slider slider;
    public AudioSource Msource;

    //Sets slider to the Playerpref value and saves the value as a player pref
    private void Start()
    {
        if(!PlayerPrefs.HasKey("Mslider"))
        {
            PlayerPrefs.SetFloat("Mslider", 1.0f);
        }
        slider.value = PlayerPrefs.GetFloat("Mslider");
    }


    void Update()
    {
        PlayerPrefs.SetFloat("Mslider", slider.value);
        Msource.volume = PlayerPrefs.GetFloat("Mslider");
    }
}
