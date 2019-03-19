using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour
{
    public Text HighScoreList;



    // Update is called once per frame
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
}
