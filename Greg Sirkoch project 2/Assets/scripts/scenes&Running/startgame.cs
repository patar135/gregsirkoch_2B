using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startgame : MonoBehaviour
{
    //simple scene loading
    public void StartFrogging()
    {
        SceneManager.LoadScene("gamescene");
    }

    
}
