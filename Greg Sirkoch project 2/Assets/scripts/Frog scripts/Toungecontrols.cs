using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Toungecontrols : MonoBehaviour
{
    private Vector3 direction = new Vector3(1, 0, 0);
    private Vector3 mousePosition;

    public AudioSource tungsource;
    public AudioClip crunch;

    //variables for the tounge
    private float angle;
    private float distance;
    private float height;
    public bool tungout;
    private float growing;
    private bool isGrowing;
    private Scores scores;

    //controls if the script runs
    public bool working = false;
    
    void Start()
    {

        //setting up the renderers and volume for sounds
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        scores = gameObject.GetComponentInParent<Scores>();
        tungsource.volume = GameObject.Find("SFX").GetComponent<SFXvolume>().SFXvolumes;

    }

    // Update is called once per frame
    void Update()
    {
        //finds mouse position
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        



        if (working == true)
        {

            //method for clicking and spawning the tounge
            if (Input.GetMouseButtonDown(0) && tungout == false)
            {


                Spawntung();



                Invoke("Despawntung", .5f);

            }
            if (tungout == true && transform.localScale.x <= .53663f)
            {
                if (transform.localScale.x >= .5)
                {
                    isGrowing = false;
                }

                if (isGrowing == true)
                {
                    growing += .05f;
                }
                else if (isGrowing == false && transform.localScale.x >= 0)
                {
                    growing += -.05f;
                }
                if (transform.localScale.x < 0)
                {
                    transform.localScale = new Vector3(0, .53663f, .53663f);
                }

                transform.localScale = new Vector3(growing, .53663f, .53663f);




            }

        }
    }


    //does the tounge math
    void Spawntung()
    {
        distance = Mathf.Sqrt(Mathf.Pow((mousePosition.x - transform.position.x), 2) + Mathf.Pow((mousePosition.y - transform.position.y), 2));
        height = mousePosition.y - transform.position.y;
        transform.localScale = new Vector3(0, .53663f, .53663f);
        isGrowing = true;
        if (mousePosition.x < transform.position.x)
        {
            angle = -(Mathf.Rad2Deg * Mathf.Asin(height / distance));
            gameObject.GetComponent<SpriteRenderer>().flipY = false;

        }
        else if (mousePosition.x > transform.position.x)
        {
            angle = -(180 - (Mathf.Rad2Deg * Mathf.Asin(height / distance)));
            gameObject.GetComponent<SpriteRenderer>().flipY = true;
        }
        tungout = true;

        transform.Rotate(new Vector3(0, 0, angle));
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<PolygonCollider2D>().enabled = true;


    }


    void Despawntung()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        transform.rotation = Quaternion.identity;
        tungout = false;
        growing = 0;
    }


    //checks to find if it collides with an item
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "slurped")
        {

            tungsource.clip = crunch;
            tungsource.Play();
            Destroy(collision.gameObject);
            scores.morescore();

        }
        
        else if (collision.gameObject.tag == "Cookedegg")
        {
            tungsource.clip = crunch;
            tungsource.Play();
            Destroy(collision.gameObject);
            scores.morescore();
            scores.morescore();
            scores.morescore();

        }
        else if (collision.gameObject.tag == "Baby")
        {
            tungsource.clip = crunch;
            tungsource.Play();
            Destroy(collision.gameObject);
            scores.gainlife();
            scores.morescore();

        }

    }



}




