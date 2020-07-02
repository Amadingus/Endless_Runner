using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipNormalise : MonoBehaviour
{
  

    public float spd;
    public float xPos;




    void Update()
    {
        transform.Translate(Vector2.left * spd * Time.deltaTime);
        if (transform.position.x <= xPos)
        {
            Destroy(gameObject);
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManagerScript.PlaySound("normalise");
            Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
            Destroy(gameObject);
        }


    }
}
