using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighSlurps : MonoBehaviour
{
    //Scene loader
    public void GoToHighSlurps()
    {
        SceneManager.LoadScene("HighScores");
    }
}
