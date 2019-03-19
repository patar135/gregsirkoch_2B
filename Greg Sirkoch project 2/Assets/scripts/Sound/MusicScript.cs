using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicScript : MonoBehaviour
{
 
  


    public AudioSource audioplayer;


    //plays the music and ambience and deletes itself if it finds a copy upon creating itself
    void Start()
    {
        audioplayer.Play();
        



    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (GameObject.Find(gameObject.name)
                  && GameObject.Find(gameObject.name) != this.gameObject)
        {
            Destroy(GameObject.Find(gameObject.name));
        }
    }

    
    
    
    
    

}
