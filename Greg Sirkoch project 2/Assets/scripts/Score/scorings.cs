using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorings : MonoBehaviour
{
    public Text score;
    public Scores scores;
    
    

    //shows the lives and score at the top of the screen
    void Awake()
    {
        score = gameObject.GetComponent<Text>();
        scores = GameObject.Find("Froggy").GetComponent<Scores>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = $"Score: {scores.score}       Lives: {scores.lives}"; 
        


    }
}
