using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXslider : MonoBehaviour
{
    public Slider slider;


    //Sets slider to the Playerpref value and saves the value as a player pref
    private void Start()
    {
        if (!PlayerPrefs.HasKey("SFXslider"))
        {
            PlayerPrefs.SetFloat("SFXslider", 1.0f);
        }
        slider.value = PlayerPrefs.GetFloat("SFXslider");
    }


    void Update()
    {
        PlayerPrefs.SetFloat("SFXslider", slider.value);
        //SFXsource.volume = PlayerPrefs.GetFloat("SFXslider");
    }
}
