
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{

    private Vector2 playerPos;
    public float Ymove;
    public float spd;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public Text healthPoints;
    public GameObject gameOver;



    // Update is called once per frame
    void Update()
    {
        healthPoints.text = health.ToString();

        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, playerPos, spd * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            playerPos = new Vector2(transform.position.x, transform.position.y + Ymove);
         
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            playerPos = new Vector2(transform.position.x, transform.position.y - Ymove);
            
        }
    }
}

