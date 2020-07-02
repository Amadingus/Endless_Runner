using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public int healing = 1;
    public float spd;
    public float xPos;

    private void Update()
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
            SoundManagerScript.PlaySound("healthPickup");

            other.GetComponent<Player_Movement>().health += healing;
            Debug.Log(other.GetComponent<Player_Movement>().health);
            Destroy(gameObject);
        }
    }
}
