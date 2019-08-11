using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float spd;
    public float xPos;

    public GameObject effect;

    private void Update()
    {
        transform.Translate(Vector2.left * spd * Time.deltaTime);
        if(transform.position.x <= xPos)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<Player_Movement>().health -= damage;
            Debug.Log(other.GetComponent<Player_Movement>().health);
            Destroy(gameObject);
        }
    }
}
