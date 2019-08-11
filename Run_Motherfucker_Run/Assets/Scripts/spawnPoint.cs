using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject FlipDebuff;
    public GameObject FlipNormalise;


    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
        Instantiate(FlipNormalise, transform.position, Quaternion.identity);
        Instantiate(FlipDebuff, transform.position, Quaternion.identity);

    }

   
}
