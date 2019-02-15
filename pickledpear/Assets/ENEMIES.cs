using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMIES : MonoBehaviour
{
    public float speed = 1.00f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed);

        if (transform.position.x < -3f)
        {
            speed = speed * -1;
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
        }


        if (transform.position.x > 3f)
        {
            speed = speed * -1;
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);

        }
    }
}