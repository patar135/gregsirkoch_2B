using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class froggymove : MonoBehaviour
{
    public float speed;
    private float bound = 7.9f;
    private Vector3 direction = new Vector3(1, 0, 0);
    private Vector3 mousePosition;
    public bool enablemovement = false;

 

   
    void Update()
    {
        //makes the frog go toward the mouse in the x direction
        if (enablemovement == true)
        {
            transform.position += direction * speed * Time.deltaTime;

            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);


            if (mousePosition.x < transform.position.x)
            {
                direction.x = -1;
            }
            else if (mousePosition.x > transform.position.x)
            {
                direction.x = 1;
            }

            else if (mousePosition.x == transform.position.x)
            {
                direction.x = 0;
            }

           

        }





    }
}
