using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{

     private int defaultHighScore = 0;
     //public Text HighScoreList;


    List<int> hiscorelist = new List<int>();
    public float musicvalue;
    public float brethrenvalue;
    public float SFXvalue;








    //sets all the high score to default values if doesnt exist
    void Start()
    {



        if (!PlayerPrefs.HasKey("High Score 1"))
        {
            PlayerPrefs.SetInt("High Score 1", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 2"))
        {
            PlayerPrefs.SetInt("High Score 2", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 3"))
        {
            PlayerPrefs.SetInt("High Score 3", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 4"))
        {
            PlayerPrefs.SetInt("High Score 4", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 5"))
        {
            PlayerPrefs.SetInt("High Score 5", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 6"))
        {
            PlayerPrefs.SetInt("High Score 6", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 7"))
        {
            PlayerPrefs.SetInt("High Score 7", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 8"))
        {
            PlayerPrefs.SetInt("High Score 8", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 9"))
        {
            PlayerPrefs.SetInt("High Score 9", defaultHighScore);
        }
        if (!PlayerPrefs.HasKey("High Score 10"))
        {
            PlayerPrefs.SetInt("High Score 10", defaultHighScore);
        }


        for (int i = 1; i <= 10; i++)
        {

            hiscorelist.Add(PlayerPrefs.GetInt("High Score " + i.ToString()));

        }

        





    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }




    //Creates a high score list of player preferences
    public void GameOver()
    {


         if(GameObject.Find("Froggy").GetComponent<Scores>().score > hiscorelist[9])
        {
            hiscorelist.Add(GameObject.Find("Froggy").GetComponent<Scores>().score);
            hiscorelist.Sort();
            hiscorelist.Reverse();

            for(int i = 1; i <= 10; i++)
            {

                PlayerPrefs.SetInt("High Score " + i.ToString(), hiscorelist[i - 1]);

            }


        }


     
        
    }

    //formats the score board


        /*
    void Update()
        {
        HighScoreList.text = $"1:                                 " + PlayerPrefs.GetInt("High Score 1") + "\n" +
            $"2:                                 " + PlayerPrefs.GetInt("High Score 2") + "\n" +
            $"3:                                 " + PlayerPrefs.GetInt("High Score 3") + "\n" +
            $"4:                                 " + PlayerPrefs.GetInt("High Score 4") + "\n" +
            $"5:                                 " + PlayerPrefs.GetInt("High Score 5") + "\n" +
            $"6:                                 " + PlayerPrefs.GetInt("High Score 6") + "\n" +
            $"7:                                 " + PlayerPrefs.GetInt("High Score 7") + "\n" +
            $"8:                                 " + PlayerPrefs.GetInt("High Score 8") + "\n" +
            $"9:                                 " + PlayerPrefs.GetInt("High Score 9") + "\n" +
            $"10:                               " + PlayerPrefs.GetInt("High Score 10") + "\n";
            
        }
    */
}
