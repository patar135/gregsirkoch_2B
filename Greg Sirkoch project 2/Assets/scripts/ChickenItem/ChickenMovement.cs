using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    public float speed;
    private Vector3 direction = new Vector3(1, 0, 0);
    [Header ("Chance to change direction")]
    public float chance;
    private float bound = 7.6f;
    public bool enablemovement = false;



    //controls the chicken with random chance of turning around and keeps it on the screen
    void Update()
    {

        if (enablemovement == true)
        {
            transform.position += direction * speed * Time.deltaTime;

            if (Random.value <= chance)
            {
                speed *= -1;
            }

            if (speed > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;

            }
            if (speed < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (transform.position.x + (direction.x * speed * Time.deltaTime) <= -bound || transform.position.x >= bound)
            {
                speed *= -1;
            }
            if (transform.position.x > bound)
            {
                transform.position = new Vector3(bound, 3.65f, 0);
            }
            if (transform.position.x < -bound)
            {
                transform.position = new Vector3(-bound, 3.65f, 0);
            }

        }
    }
}
