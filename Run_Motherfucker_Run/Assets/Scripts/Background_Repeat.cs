using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Repeat : MonoBehaviour
{
    public float speed;

    public float endPos;
    public float startPos;

   
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endPos)
        {
            Vector2 pos = new Vector2(startPos, transform.position.y);
            transform.position = pos;
        }
    }
}
