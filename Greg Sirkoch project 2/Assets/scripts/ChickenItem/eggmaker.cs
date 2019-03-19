using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggmaker : MonoBehaviour
{
    //chance to drop egg
    public float chanceforSurprise;

    //sprites for the animations
    public Sprite normal;
    public Sprite wacked;


    //chance for another item to spawn
    public float chancetospawn;

    //the other objects
    public GameObject closedegg;
    public GameObject openegg;
    public GameObject Baby;

    //values for the spawn table
    private float value;
    private float babyvalue;
    public float chanceforBABY;


    //if script is running
    public bool working = false;



    public AudioSource crowmaker;
    public AudioClip birdnoise;
    public AudioClip babysound;

    //rotating the items
    private int rotationNumber;


    void Start()
    {
        //getting the volume from the slider
        crowmaker.volume = GameObject.Find("SFX").GetComponent<SFXvolume>().SFXvolumes;
    }

    // Update is called once per frame
    void Update()
    {
        if (working == true)
        {


            

            //system for spawning the items and making noises
            value = Random.value;
            if (value <= chancetospawn)
            {
                rotationNumber = Random.Range(0, 359);

                if (value <= chanceforSurprise)
                {
                    babyvalue = Random.value;
                    
                    if (babyvalue <= chanceforBABY)
                    {
                        crowmaker.clip = babysound;
                        crowmaker.Play();

                        gameObject.GetComponent<SpriteRenderer>().sprite = wacked;

                        Instantiate(Baby, transform.position, Quaternion.Euler(0, 0, rotationNumber));
                        Invoke("ResetChicken", .2f);
                    }



                    else
                    {
                        crowmaker.clip = birdnoise;
                        crowmaker.Play();

                        gameObject.GetComponent<SpriteRenderer>().sprite = wacked;

                        Instantiate(openegg, transform.position, Quaternion.Euler(0, 0, rotationNumber));
                        Invoke("ResetChicken", .2f);
                    }
                    
                }
                else
                {

                    Instantiate(closedegg, transform.position, Quaternion.identity);
                }
            }
        }  


    }

    //resetting the sprite renderer
    void ResetChicken()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = normal;
    }
}
