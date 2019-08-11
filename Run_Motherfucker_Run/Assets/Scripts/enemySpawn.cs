using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{

    public GameObject[] obstacleForms;

    private float spawnTimer;
    public float spawnTimerStart;
    public float decreaseSpawnTime;
    public float minTime;


   
    private void Update()
    {
        if (spawnTimer <= 0)
        {
            int rand = Random.Range(0, obstacleForms.Length);
            Instantiate(obstacleForms[rand], transform.position, Quaternion.identity);
            spawnTimer = spawnTimerStart;
            if(spawnTimerStart > minTime)
            {
                spawnTimerStart -= decreaseSpawnTime;
            }
            
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
}
