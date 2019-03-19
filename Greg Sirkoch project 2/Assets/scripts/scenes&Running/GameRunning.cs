using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunning : MonoBehaviour
{



    public void enablegame()
    {
        GameObject.Find("Froggy").GetComponent<froggymove>().enablemovement = true;
        GameObject.Find("chiecn spritebird").GetComponent<ChickenMovement>().enablemovement = true;
        GameObject.Find("chiecn spritebird").GetComponent<eggmaker>().working = true;
        GameObject.Find("frog tongue sprite_0").GetComponent<Toungecontrols>().working = true;

 


        
       
    }
    public void disablegame()
    {
        GameObject.Find("Froggy").GetComponent<froggymove>().enablemovement = false;
        GameObject.Find("chiecn spritebird").GetComponent<ChickenMovement>().enablemovement = false;
        GameObject.Find("chiecn spritebird").GetComponent<eggmaker>().working = false;
        GameObject.Find("frog tongue sprite_0").GetComponent<Toungecontrols>().working = false;



        
        Destroy(GameObject.FindWithTag("slurped"));
        Destroy(GameObject.FindWithTag("Cookedegg"));
        Destroy(GameObject.FindWithTag("Baby"));
    }


}
