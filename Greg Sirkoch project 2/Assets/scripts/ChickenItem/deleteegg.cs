using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteegg : MonoBehaviour
{
    private GameObject frog;
    private Scores scores;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //deletes items and subtracts score if the frog misses them
        if (collision.gameObject.tag == "slurped")
        {
            Destroy(collision.gameObject);
            scores.losescore();

        }

        else if (collision.gameObject.tag == "Cookedegg")
        {
            Destroy(collision.gameObject);
            scores.losescore();
            

        }
        else if (collision.gameObject.tag == "Baby")
        {
            Destroy(collision.gameObject);
            scores.losescore();


        }

    }


   
    void Awake()
    {
        frog = GameObject.Find("Froggy");
        scores = frog.GetComponent<Scores>();
    }

    
}
