using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipNormalise : MonoBehaviour
{
    public GameObject playerCam;

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
            playerCam.transform.eulerAngles = Vector3.forward * 0;
            Destroy(gameObject);
        }


    }
}
