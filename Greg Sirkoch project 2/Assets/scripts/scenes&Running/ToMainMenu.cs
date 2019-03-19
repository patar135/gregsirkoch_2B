using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    //scene loader
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
