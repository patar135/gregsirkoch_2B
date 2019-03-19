using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facecollide : MonoBehaviour
{
    //animation sprites
    public Sprite Normal;
    public Sprite Hurt;

    public AudioSource getHitNoise;
    public AudioClip owch;


    //connects to keeping score
    private Scores scores;

    
    //sets up sounds and scores
    void Start()
    {
        scores = gameObject.GetComponentInParent<Scores>();
        getHitNoise.clip = owch;
        getHitNoise.volume = GameObject.Find("SFX").GetComponent<SFXvolume>().SFXvolumes;
        
    }

    
    void Update()
    {

 
    }


    //checks to see if its colliding with anything
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "slurped")
        {
            getHitNoise.Play();
            Destroy(collision.gameObject);
            scores.loselife();
            gameObject.GetComponent<SpriteRenderer>().sprite = Hurt;
            Invoke("ResetFrog", .2f);
        }

        else if (collision.gameObject.tag == "Cookedegg")
        {
            getHitNoise.Play();
            Destroy(collision.gameObject);
            scores.loselife();
            gameObject.GetComponent<SpriteRenderer>().sprite = Hurt;
            Invoke("ResetFrog", .2f);
        }

    }
    private void ResetFrog()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
    }
}
